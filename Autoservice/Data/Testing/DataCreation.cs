using System;
using System.Collections.Generic;
using System.Linq;
using Autoservice.Entities;
using Common.Data.IO.Interfaces;

namespace Autoservice.Data.Testing
{
    public static class DataCreation
    {
        public static void CreateTestingOwners(this ICollection<Owner> owners)
        {
            owners.Add(new Owner("Іван Іванов", "ivan@example.com", "Київ, Україна") { Id = 1 });
            owners.Add(new Owner("Петро Петров", "petro@example.com", "Львів, Україна") { Id = 2 });
            owners.Add(new Owner("Олексій Олексієнко", "oleksiy@example.com", "Одеса, Україна") { Id = 3 });
            owners.Add(new Owner("Марія Маріївна", "maria@example.com", "Харків, Україна") { Id = 4 });
            owners.Add(new Owner("Сергій Сергієнко", "sergiy@example.com", "Дніпро, Україна") { Id = 5 });
        }

        public static void CreateTestingTransports(this ICollection<Transport> transports, ICollection<Owner> owners)
        {
            var owner1 = owners.FirstOrDefault(o => o.Name == "Іван Іванов");
            var owner2 = owners.FirstOrDefault(o => o.Name == "Петро Петров");
            var owner3 = owners.FirstOrDefault(o => o.Name == "Олексій Олексієнко");
            var owner4 = owners.FirstOrDefault(o => o.Name == "Марія Маріївна");
            var owner5 = owners.FirstOrDefault(o => o.Name == "Сергій Сергієнко");

            if (owner1 == null || owner2 == null || owner3 == null || owner4 == null || owner5 == null)
                throw new Exception("Один із власників не знайдений! Перевірте CreateTestingOwners.");

            var t1 = new Transport("Toyota", "Camry", "AA1234AA", "Седан", owner1) { Id = 1 };
            var t2 = new Transport("Honda", "Civic", "BB5678BB", "Хетчбек", owner2, t1) { Id = 2 };
            var t3 = new Transport("Ford", "Focus", "CC9101CC", "Седан", owner3, t2) { Id = 3 };
            var t4 = new Transport("Mazda", "3", "DD1122DD", "Седан", owner4, t3) { Id = 4 };
            var t5 = new Transport("Volkswagen", "Passat", "EE3344EE", "Універсал", owner5, t4) { Id = 5 };

            transports.Add(t1);
            transports.Add(t2);
            transports.Add(t3);
            transports.Add(t4);
            transports.Add(t5);
        }

        public static void CreateTestingServices(this ICollection<Service> services)
        {
            services.Add(new Service("Заміна масла", 500, TimeSpan.FromHours(1), TimeSpan.FromDays(30)) { Id = 1 });
            services.Add(new Service("Ремонт двигуна", 10000, TimeSpan.FromDays(3), TimeSpan.FromDays(365)) { Id = 2 });
            services.Add(new Service("Діагностика", 300, TimeSpan.FromMinutes(40), TimeSpan.FromDays(180)) { Id = 3 });
            services.Add(new Service("Мийка кузова", 200, TimeSpan.FromMinutes(30), TimeSpan.FromDays(7)) { Id = 4 });
            services.Add(new Service("Заміна колодок", 800, TimeSpan.FromHours(2), TimeSpan.FromDays(180)) { Id = 5 });
        }

        public static void CreateTestingMaintenances(this ICollection<Maintenance> maintenances, ICollection<Transport> transports, ICollection<Service> services)
        {
            Maintenance AddMaintenance(string transportNumber, string serviceName, DateTime date, decimal cost, string note, int id)
            {
                var transport = transports.FirstOrDefault(t => t.Number == transportNumber);
                if (transport == null)
                    throw new Exception($"Transport '{transportNumber}' not found!");

                var service = services.FirstOrDefault(s => s.Name == serviceName);
                if (service == null)
                    throw new Exception($"Service '{serviceName}' not found!");

                return new Maintenance(transport, service, date, cost, note) { Id = id };
            }

            maintenances.Add(AddMaintenance("AA1234AA", "Заміна масла", DateTime.Now, 500, "Заміна масла та фільтра", 1));
            maintenances.Add(AddMaintenance("BB5678BB", "Ремонт двигуна", DateTime.Now, 10000, "Капітальний ремонт двигуна", 2));
            maintenances.Add(AddMaintenance("CC9101CC", "Діагностика", DateTime.Now.AddDays(-10), 300, "Планова діагностика", 3));
            maintenances.Add(AddMaintenance("DD1122DD", "Мийка кузова", DateTime.Now.AddDays(-5), 200, "Мийка після поїздки", 4));
            maintenances.Add(AddMaintenance("EE3344EE", "Заміна колодок", DateTime.Now.AddDays(-2), 800, "Заміна передніх колодок", 5));
        }

        public static bool CreateTestingData(this IDataSet dataSet)
        {
            if (dataSet.IsEmpty())
            {
                dataSet.Owners.CreateTestingOwners();
                dataSet.Transports.CreateTestingTransports(dataSet.Owners);
                dataSet.Services.CreateTestingServices();
                dataSet.Maintenances.CreateTestingMaintenances(dataSet.Transports, dataSet.Services);
                return true;
            }
            return false;
        }
    }
}