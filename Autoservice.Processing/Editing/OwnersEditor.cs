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
    public class OwnersEditor : EntityEditor<Owner, OwnerModel>, IOwnerEditor
    {
        protected readonly IDataContext _dataContext;

        public OwnersEditor(IDataContext dataContext)
            : base(dataContext.Owners)
        {
            _dataContext = dataContext;
        }

        public override IEnumerable<OwnerModel> GetModels()
        {
            return SortedObjects.Select(e => new OwnerModel
            {
                Id = e.Id,
                Name = e.Name,
                Email = e.Email,
                Address = e.Address,
                Key = e.Key
            });
        }

        public override void Save()
        {
            throw new NotImplementedException();
        }

        protected override void AddNewObject(OwnerModel model)
        {
            var owner = new Owner(
                model.Name,
                model.Email,
                model.Address
            )
            { Id = model.Id };

            Collection.Add(owner);
        }

        protected override bool CheckCreation(OwnerModel model)
        {
            if (Collection.Any(e => !string.IsNullOrEmpty(model.Name)
                && string.Compare(e.Name, model.Name.Trim(), StringComparison.OrdinalIgnoreCase) == 0))
            {
                OnNameError(CrudMode.Creation, model);
                return false;
            }
            if (!string.IsNullOrEmpty(model.Email) &&
                Collection.Any(e => string.Compare(e.Email, model.Email.Trim(), StringComparison.OrdinalIgnoreCase) == 0))
            {
                OnEmailError(CrudMode.Creation, model);
                return false;
            }
            return true;
        }

        protected override bool CheckUpdating(OwnerModel model)
        {
            if (Collection.Any(e => e.Key != model.Key
                && !string.IsNullOrEmpty(model.Name)
                && string.Compare(e.Name, model.Name.Trim(), StringComparison.OrdinalIgnoreCase) == 0))
            {
                OnNameError(CrudMode.Updating, model);
                return false;
            }
            if (!string.IsNullOrEmpty(model.Email) &&
                Collection.Any(e => e.Key != model.Key &&
                    string.Compare(e.Email, model.Email.Trim(), StringComparison.OrdinalIgnoreCase) == 0))
            {
                OnEmailError(CrudMode.Updating, model);
                return false;
            }
            return true;
        }

        protected override bool CheckDeleting(OwnerModel model)
        {
            return true;
        }

        protected override void UpdateObject(OwnerModel model, Owner obj)
        {
            obj.Name = model.Name;
            obj.Email = model.Email;
            obj.Address = model.Address;
        }

        private void OnNameError(CrudMode mode, OwnerModel model)
        {
            OnActionError(new ActionInfoEventArgs(mode, nameof(Owner), model,
                $"Помилка: у сховищі вже є власник з іменем \"{model.Name}\"."));
        }

        private void OnEmailError(CrudMode mode, OwnerModel model)
        {
            OnActionError(new ActionInfoEventArgs(mode, nameof(Owner), model,
                $"Помилка: у сховищі вже є власник з email \"{model.Email}\"."));
        }
    }
}