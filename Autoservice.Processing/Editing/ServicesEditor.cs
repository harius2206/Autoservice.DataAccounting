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
    public class ServicesEditor : EntityEditor<Service, ServiceModel>, IServicesEditor
    {
        protected readonly IDataContext _dataContext;

        public ServicesEditor(IDataContext dataContext)
            : base(dataContext.Services)
        {
            _dataContext = dataContext;
        }

        public override IEnumerable<ServiceModel> GetModels()
        {
            return SortedObjects.Select(e => new ServiceModel
            {
                Id = e.Id,
                Name = e.Name,
                Price = e.Price,
                Duration = e.Duration,
                WarrantyPeriod = e.WarrantyPeriod,
                Key = e.Key
            });
        }

        public override void Save()
        {
            throw new NotImplementedException();
        }

        protected override void AddNewObject(ServiceModel model)
        {
            var service = new Service(
                model.Name,
                model.Price ?? 0m,
                model.Duration ?? TimeSpan.Zero,
                model.WarrantyPeriod ?? TimeSpan.Zero
            )
            { Id = model.Id };

            Collection.Add(service);
        }

        protected override bool CheckCreation(ServiceModel model)
        {
            if (Collection.Any(e => !string.IsNullOrEmpty(model.Name)
                && string.Compare(e.Name, model.Name.Trim(), StringComparison.OrdinalIgnoreCase) == 0))
            {
                OnNameError(CrudMode.Creation, model);
                return false;
            }
            if (Collection.Any(e => e.Price == model.Price && e.Name != model.Name))
            {
                OnPriceError(CrudMode.Creation, model);
                return false;
            }
            return true;
        }

        protected override bool CheckUpdating(ServiceModel model)
        {
            if (Collection.Any(e => e.Key != model.Key
                && !string.IsNullOrEmpty(model.Name)
                && string.Compare(e.Name, model.Name.Trim(), StringComparison.OrdinalIgnoreCase) == 0))
            {
                OnNameError(CrudMode.Updating, model);
                return false;
            }
            if (Collection.Any(e => e.Key != model.Key && e.Price == model.Price && e.Name != model.Name))
            {
                OnPriceError(CrudMode.Updating, model);
                return false;
            }
            return true;
        }

        protected override bool CheckDeleting(ServiceModel model)
        {
            return true;
        }

        protected override void UpdateObject(ServiceModel model, Service obj)
        {
            obj.Name = model.Name;
            obj.Price = model.Price;
            obj.Duration = model.Duration;
            obj.WarrantyPeriod = model.WarrantyPeriod;
        }

        private void OnNameError(CrudMode mode, ServiceModel model)
        {
            OnActionError(new ActionInfoEventArgs(mode, nameof(Service), model,
                $"Помилка: у сховищі вже є сервіс з назвою \"{model.Name}\"."));
        }

        private void OnPriceError(CrudMode mode, ServiceModel model)
        {
            OnActionError(new ActionInfoEventArgs(mode, nameof(Service), model,
                $"Помилка: у сховищі вже є сервіс з ціною \"{model.Price}\" (але з іншою назвою)."));
        }
    }
}