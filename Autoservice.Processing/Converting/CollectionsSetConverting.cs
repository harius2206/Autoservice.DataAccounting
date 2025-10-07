using Autoservice.Entities;
using Common.Data.IO.Interfaces;

namespace Autoservice.Processing.Converting
{
    public static class CollectionsSetConverting
    {
        public static ModelsListsSet ToModelsListsSet(this IDataSet dataSet)
        {
            ModelsListsSet listsSet = new ModelsListsSet();

            foreach (var item in dataSet.Owners)
            {
                listsSet.OwnerModels.Add(ToOwnerModel(item));
            }
            foreach (var item in dataSet.Transports)
            {
                listsSet.TransportModels.Add(ToTransportModel(item));
            }
            foreach (var item in dataSet.Services)
            {
                listsSet.ServiceModels.Add(ToServiceModel(item));
            }
            if (dataSet.Maintenances != null)
            {
                foreach (var item in dataSet.Maintenances)
                {
                    listsSet.MeintenanceModels.Add(ToMeintenanceModel(item));
                }
            }
            return listsSet;
        }

        private static OwnerModel ToOwnerModel(Owner owner)
        {
            if (owner == null) return null;
            return new OwnerModel
            {
                Id = owner.Id,
                Name = owner.Name,
                Email = owner.Email,
                Address = owner.Address,
                Key = owner.Key
            };
        }

        private static TransportModel ToTransportModel(Transport transport)
        {
            if (transport == null) return null;
            return new TransportModel
            {
                Id = transport.Id,
                Make = transport.Make,
                Model = transport.Model,
                Number = transport.Number,
                Description = transport.Description,
                OwnerKey = transport.Owner != null ? transport.Owner.Key : null,
                ParentKey = transport.Parent != null ? transport.Parent.Key : null,
                Key = transport.Key
            };
        }

        private static ServiceModel ToServiceModel(Service service)
        {
            if (service == null) return null;
            return new ServiceModel
            {
                Id = service.Id,
                Name = service.Name,
                Price = service.Price,
                Duration = service.Duration,
                WarrantyPeriod = service.WarrantyPeriod,
                Key = service.Key
            };
        }

        private static MeintenanceModel ToMeintenanceModel(Maintenance maintenance)
        {
            if (maintenance == null) return null;
            return new MeintenanceModel
            {
                Id = maintenance.Id,
                TransportKey = maintenance.Transport != null ? maintenance.Transport.Key : null,
                ServiceKey = maintenance.Service != null ? maintenance.Service.Key : null,
                Date = maintenance.Date,
                Cost = maintenance.Cost,
                Note = maintenance.Note,
                Key = maintenance.Key
            };
        }
    }
}