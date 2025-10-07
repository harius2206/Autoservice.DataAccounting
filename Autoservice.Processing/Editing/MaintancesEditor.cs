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
    public class MaintancesEditor : EntityEditor<Maintenance, MeintenanceModel>, IMaintancesEditor
    {
        protected readonly IDataContext _dataContext;

        private List<Transport> _transports;
        private List<Service> _services;

        public IEnumerable<string> TransportSelectionItems => _transports.Select(e => e.Key).ToList();
        public IEnumerable<string> ServiceSelectionItems => _services.Select(e => e.Key).ToList();

        public MaintancesEditor(IDataContext dataContext)
            : base(dataContext.Maintenances)
        {
            _dataContext = dataContext;
            RefreshReferences();
        }

        private void RefreshReferences()
        {
            _transports = _dataContext.Transports.OrderBy(e => e.Key).ToList();
            _services = _dataContext.Services.OrderBy(e => e.Key).ToList();
        }

        public override IEnumerable<MeintenanceModel> GetModels()
        {
            return SortedObjects.Select(e => new MeintenanceModel
            {
                Id = e.Id,
                Key = e.Key,
                TransportKey = e.Transport?.Key,
                ServiceKey = e.Service?.Key,
                Date = e.Date,
                Cost = e.Cost,
                Note = e.Note
            });
        }

        public override void Save()
        {
            // Реалізуй збереження, якщо потрібно
            throw new NotImplementedException();
        }

        protected override void AddNewObject(MeintenanceModel model)
        {
            RefreshReferences();
            var transport = _transports.FirstOrDefault(t => t.Key == model.TransportKey);
            var service = _services.FirstOrDefault(s => s.Key == model.ServiceKey);

            var maintenance = new Maintenance(
                transport,
                service,
                model.Date ?? DateTime.MinValue,
                model.Cost ?? 0m,
                model.Note
            )
            { Id = model.Id };

            Collection.Add(maintenance);
        }

        protected override bool CheckCreation(MeintenanceModel model)
        {
            RefreshReferences();
            // Перевірка на дубль
            if (Collection.Any(e =>
                e.Transport != null && e.Transport.Key == model.TransportKey &&
                e.Service != null && e.Service.Key == model.ServiceKey &&
                e.Date == model.Date))
            {
                OnDuplicateError(CrudMode.Creation, model);
                return false;
            }
            // Перевірка на існування транспорту
            if (!string.IsNullOrEmpty(model.TransportKey) && !_transports.Any(t => t.Key == model.TransportKey))
            {
                OnTransportError(CrudMode.Creation, model);
                return false;
            }
            // Перевірка на існування послуги
            if (!string.IsNullOrEmpty(model.ServiceKey) && !_services.Any(s => s.Key == model.ServiceKey))
            {
                OnServiceError(CrudMode.Creation, model);
                return false;
            }
            return true;
        }

        protected override bool CheckDeleting(MeintenanceModel model)
        {
            return true;
        }

        protected override bool CheckUpdating(MeintenanceModel model)
        {
            RefreshReferences();
            if (Collection.Any(e =>
                e.Key != model.Key &&
                e.Transport != null && e.Transport.Key == model.TransportKey &&
                e.Service != null && e.Service.Key == model.ServiceKey &&
                e.Date == model.Date))
            {
                OnDuplicateError(CrudMode.Updating, model);
                return false;
            }
            if (!string.IsNullOrEmpty(model.TransportKey) && !_transports.Any(t => t.Key == model.TransportKey))
            {
                OnTransportError(CrudMode.Updating, model);
                return false;
            }
            if (!string.IsNullOrEmpty(model.ServiceKey) && !_services.Any(s => s.Key == model.ServiceKey))
            {
                OnServiceError(CrudMode.Updating, model);
                return false;
            }
            return true;
        }

        private void OnDuplicateError(CrudMode mode, MeintenanceModel model)
        {
            OnActionError(new ActionInfoEventArgs(mode, nameof(Maintenance), model,
                $"Помилка: у сховищі вже є запис обслуговування для цього транспорту, послуги та дати."));
        }

        private void OnTransportError(CrudMode mode, MeintenanceModel model)
        {
            OnActionError(new ActionInfoEventArgs(mode, nameof(Maintenance), model,
                $"Помилка: не знайдено транспорт з ключем \"{model.TransportKey}\"."));
        }

        private void OnServiceError(CrudMode mode, MeintenanceModel model)
        {
            OnActionError(new ActionInfoEventArgs(mode, nameof(Maintenance), model,
                $"Помилка: не знайдено послугу з ключем \"{model.ServiceKey}\"."));
        }

        protected override void UpdateObject(MeintenanceModel model, Maintenance obj)
        {
            RefreshReferences();
            obj.Transport = _transports.FirstOrDefault(t => t.Key == model.TransportKey);
            obj.Service = _services.FirstOrDefault(s => s.Key == model.ServiceKey);
            obj.Date = model.Date;
            obj.Cost = model.Cost;
            obj.Note = model.Note;
        }
    }
}