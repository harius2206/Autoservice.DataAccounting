using Autoservice.Data.Interfaces;
using Autoservice.Entities;
using Autoservice.Processing.Interfaces;
using Common.Processing.Editing;
using Common.Processing.Events;
using Common.Processing.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Autoservice.Processing.Editing
{
    public class TransportsEditor : EntityEditor<Transport, TransportModel>, ITransportsEditor
    {
        protected readonly IDataContext _dataContext;

        private List<Owner> _owners;
        private List<Transport> _allTransports;


        public IEnumerable<string> ParentSelectionItems => _allTransports.Select(e => e.Key).ToList();
        public IEnumerable<string> VlasnukSelectionItems => _owners.Select(o => o.Key).ToList();

        IEnumerable<string> ITransportsEditor.ParentSelectionItems => ParentSelectionItems;
        IEnumerable<string> ITransportsEditor.VlasnukSelectionItems => VlasnukSelectionItems;

        public TransportsEditor(IDataContext dataContext)
            : base(dataContext.Transports)
        {
            _dataContext = dataContext;
            RefreshReferences();
        }

        private void RefreshReferences()
        {
            _owners = _dataContext.Owners.OrderBy(e => e.Key).ToList();
            _allTransports = _dataContext.Transports.OrderBy(e => e.Key).ToList();
        }

        public override IEnumerable<TransportModel> GetModels()
        {
            return SortedObjects.Select(e => new TransportModel
            {
                Id = e.Id,
                Make = e.Make,
                Model = e.Model,
                Number = e.Number,
                Description = e.Description,
                OwnerKey = e.Owner?.Key,
                ParentKey = e.Parent?.Key,
                ParentMake = e.Parent?.Make,      
                ParentModel = e.Parent?.Model,    
                Key = e.Key
            });
        }

        public override void Save()
        {
            // Реалізуй збереження, якщо потрібно
            throw new NotImplementedException();
        }

        protected override void AddNewObject(TransportModel model)
        {
            RefreshReferences();
            var owner = _owners.FirstOrDefault(o => o.Key == model.OwnerKey);
            var parent = _allTransports.FirstOrDefault(t => t.Key == model.ParentKey);

            var transport = new Transport(
                model.Make,
                model.Model,
                model.Number,
                model.Description,
                owner,
                parent
            )
            { Id = model.Id };

            Collection.Add(transport);
        }

        protected override bool CheckCreation(TransportModel model)
        {
            RefreshReferences();
            // Перевірка на дубль номера
            if (Collection.Any(e => !string.IsNullOrEmpty(model.Number)
                && string.Compare(e.Number, model.Number.Trim(), StringComparison.OrdinalIgnoreCase) == 0))
            {
                OnNumberError(CrudMode.Creation, model);
                return false;
            }
            // Перевірка на існування власника
            if (!string.IsNullOrEmpty(model.OwnerKey) && !_owners.Any(o => o.Key == model.OwnerKey))
            {
                OnOwnerError(CrudMode.Creation, model);
                return false;
            }
            // Перевірка на існування батьківського транспорту (якщо задано)
            if (!string.IsNullOrEmpty(model.ParentKey) && !_allTransports.Any(t => t.Key == model.ParentKey))
            {
                OnParentError(CrudMode.Creation, model);
                return false;
            }
            // Перевірка на самопризначення
            if (!string.IsNullOrEmpty(model.ParentKey) && model.ParentKey == model.Key)
            {
                OnParentSelfError(CrudMode.Creation, model);
                return false;
            }
            return true;
        }

        protected override bool CheckUpdating(TransportModel model)
        {
            RefreshReferences();
            if (Collection.Any(e => e.Key != model.Key
                && !string.IsNullOrEmpty(model.Number)
                && string.Compare(e.Number, model.Number.Trim(), StringComparison.OrdinalIgnoreCase) == 0))
            {
                OnNumberError(CrudMode.Updating, model);
                return false;
            }
            if (!string.IsNullOrEmpty(model.OwnerKey) && !_owners.Any(o => o.Key == model.OwnerKey))
            {
                OnOwnerError(CrudMode.Updating, model);
                return false;
            }
            if (!string.IsNullOrEmpty(model.ParentKey))
            {
                if (model.ParentKey == model.Key)
                {
                    OnParentSelfError(CrudMode.Updating, model);
                    return false;
                }
                else if (!_allTransports.Any(t => t.Key == model.ParentKey))
                {
                    OnParentError(CrudMode.Updating, model);
                    return false;
                }
            }
            return true;
        }

        protected override bool CheckDeleting(TransportModel model)
        {
            RefreshReferences();
            if (_allTransports.Any(t => t.Parent != null && t.Parent.Key == model.Key))
            {
                OnDeleteParentError(CrudMode.Deleting, model);
                return false;
            }
            var maintenances = (_dataContext as dynamic)?.Maintenances as IEnumerable<Maintenance>;
            if (maintenances != null && maintenances.Any(m => m.Transport != null && m.Transport.Key == model.Key))
            {
                OnDeleteMaintenanceError(CrudMode.Deleting, model);
                return false;
            }
            return true;
        }

        protected override void UpdateObject(TransportModel model, Transport obj)
        {
            RefreshReferences();
            obj.Make = model.Make;
            obj.Model = model.Model;
            obj.Number = model.Number;
            obj.Description = model.Description;
            obj.Owner = _owners.FirstOrDefault(o => o.Key == model.OwnerKey);
            obj.Parent = _allTransports.FirstOrDefault(t => t.Key == model.ParentKey);
        }

        private void OnNumberError(CrudMode mode, TransportModel model)
        {
            OnActionError(new ActionInfoEventArgs(
                mode, nameof(Transport), model,
                $"Помилка: у сховищі вже зберігається запис про транспорт з номером \"{model.Number}\"."
            ));

        }

        private void OnOwnerError(CrudMode mode, TransportModel model)
        {
            OnActionError(new ActionInfoEventArgs(
                mode, nameof(Transport), model,
                $"Помилка: не знайдено власника з ключем \"{model.OwnerKey}\"."
            ));
        }

        private void OnParentError(CrudMode mode, TransportModel model)
        {
            OnActionError(new ActionInfoEventArgs(
                mode, nameof(Transport), model,
                $"Помилка: не знайдено батьківський транспорт з ключем \"{model.ParentKey}\"."
            ));
        }

        private void OnParentSelfError(CrudMode mode, TransportModel model)
        {
            OnActionError(new ActionInfoEventArgs(
                mode, nameof(Transport), model,
                $"Помилка: транспорт не може бути власним батьком."
            ));
        }

        private void OnDeleteParentError(CrudMode mode, TransportModel model)
        {
            OnActionError(new ActionInfoEventArgs(
                mode, nameof(Transport), model,
                $"Помилка: транспорт не може бути видалений, оскільки є батьківським для іншого транспорту."
            ));
        }

        private void OnDeleteMaintenanceError(CrudMode mode, TransportModel model)
        {
            OnActionError(new ActionInfoEventArgs(
                mode, nameof(Transport), model,
                $"Помилка: транспорт не може бути видалений, оскільки використовується у записах обслуговування."
            ));
        }
    }
}