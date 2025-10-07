using System;
using Common.Entities;

namespace Autoservice.Entities
{
    [Serializable] 
    public class Service : Entity
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public TimeSpan? Duration { get; set; }
        public TimeSpan? WarrantyPeriod { get; set; }

        public override string Key
        {
            get { return Name; }
        }

        public override string ToString()
        {
            return string.Format(
                "\tПослуга №{0}\n" +
                "\tНазва: {1}\n" +
                "\tЦіна: {2}\n" +
                "\tЧас виконання: {3}\n" +
                "\tГарантійний термін: {4}",
                Id,
                Name,
                Price,
                Duration,
                WarrantyPeriod
            );
        }

        public Service(string name, decimal price, TimeSpan duration, TimeSpan warrantyPeriod)
        {
            Name = name;
            Price = price;
            Duration = duration;
            WarrantyPeriod = warrantyPeriod;
        }

        public Service() : this(null, 0, TimeSpan.Zero, TimeSpan.Zero) { }
    }
}