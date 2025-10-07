using System.Collections.Generic;
using System.Linq;
using Autoservice.Entities;

namespace Autoservice.Processing.Converting
{
    public static class ModelsConverting
    {

        public static Transport ToTransport(this TransportModel model, IEnumerable<Owner> owners, IEnumerable<Transport> transports)
        {
            return new Transport(
                model.Make,
                model.Model,
                model.Number,
                model.Description,
                owners.FirstOrDefault(o => o.Key == model.OwnerKey),
                transports.FirstOrDefault(t => t.Key == model.ParentKey)
            )
            {
                Id = model.Id
            };
        }

        public static Owner ToOwner(this OwnerModel model)
        {
            return new Owner
            {
                Id = model.Id,
                Name = model.Name,
                Email = model.Email,
                Address = model.Address,
            };
        }

        public static Service ToService(this ServiceModel model)
        {
            return new Service
            {
                Id = model.Id,
                Name = model.Name,
                Price = model.Price,
                Duration = model.Duration,
                WarrantyPeriod = model.WarrantyPeriod,
            };
        }

        public static Maintenance ToMeintenance(this MeintenanceModel model, IEnumerable<Transport> transports, IEnumerable<Service> services)
        {
            return new Maintenance
            {
                Id = model.Id,
                Transport = transports.FirstOrDefault(t => t.Key == model.TransportKey),
                Service = services.FirstOrDefault(s => s.Key == model.ServiceKey),
                Date = model.Date,
                Cost = model.Cost,
                Note = model.Note,
            };
        }
    }
}