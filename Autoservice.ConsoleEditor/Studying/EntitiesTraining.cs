using System;
using System.Collections.Generic;
using Autoservice.Entities;
using Common.Entities;

namespace Autoservice.ConsoleEditor.Studying
{
    internal class EntitiesTraining
    {
        internal static void Run()
        {
            Console.WriteLine(" === EntitiesTraining ===");
            StudyTransports();
            StudyEntities();
        }

        internal static void StudyTransports()
        {
            Console.WriteLine(" --- StudyTransports ---");

            Owner owner1 = new Owner("Іван Петров", "ivan@example.com", "Київ, Україна");
            Owner owner2 = new Owner("Петро Петров", "petro@example.com", "Львів, Україна");
            Owner owner3 = new Owner("Олексій Олексієнко", "oleksiy@example.com", "Одеса, Україна");

            Transport car1 = new Transport("Toyota", "Camry", "AA1234AA", "Седан", owner1) { Id = 1 };
            Transport car2 = new Transport("Honda", "Civic", "BB5678BB", "Хетчбек", owner2, car1) { Id = 2 };
            Transport car3 = new Transport("Ford", "Focus", "CC9101CC", "Седан", owner3, car2) { Id = 3 };

            Console.WriteLine("car1:\n{0}", car1);
            Console.WriteLine("\tБатьківський транспорт: {0}", car1.Parent != null ? $"{car1.Parent.Key} ({car1.Parent.Make} {car1.Parent.Model})" : "-");
            Console.WriteLine(new string('=', Console.BufferWidth - 1));
            Console.WriteLine("car2:\n{0}", car2);
            Console.WriteLine("\tБатьківський транспорт: {0}", car2.Parent != null ? $"{car2.Parent.Key} ({car2.Parent.Make} {car2.Parent.Model})" : "-");
            Console.WriteLine(new string('=', Console.BufferWidth - 1));
            Console.WriteLine("car3:\n{0}", car3);
            Console.WriteLine("\tБатьківський транспорт: {0}", car3.Parent != null ? $"{car3.Parent.Key} ({car3.Parent.Make} {car3.Parent.Model})" : "-");
        }

        internal static void StudyEntities()
        {
            Console.WriteLine(" --- StudyEntities ---");

            Transport obj1 = new Transport("Toyota", "Camry", "AA1234AA", "Седан", new Owner("Іван Іванов", "ivan@example.com", "Київ, Україна")) { Id = 1 };

            Console.WriteLine("obj1.ToString():\n{0}", obj1.ToString());
            Console.WriteLine("obj1:\n{0}", obj1);
            Console.WriteLine("obj1.Key: {0}", obj1.Key);

            Entity ent = obj1;
            Console.WriteLine("ent.Id: {0}", ent.Id);

            Object obj = obj1;
            Console.WriteLine("((Entity)obj).Id: {0}", ((Entity)obj).Id);

            Console.WriteLine(new string('=', Console.BufferWidth - 1));

            Transport obj2 = new Transport("Honda", "Civic", "BB5678BB", "Хетчбек", new Owner("Петро Петров", "petro@example.com", "Львів, Україна")) { Id = 2 };
            Transport obj3 = new Transport("Ford", "Focus", "CC9101CC", "Седан", new Owner("Олексій Олексієнко", "oleksiy@example.com", "Одеса, Україна")) { Id = 3 };

            List<Entity> entities = new List<Entity>()
            {
                obj1, obj2, obj3, new Transport("Mazda", "3", "DD1122DD", "Седан", new Owner("Марія Маріївна", "maria@example.com", "Харків, Україна")) { Id = 4 }
            };

            Console.WriteLine("entities:");

            foreach (Entity el in entities)
            {
                Console.WriteLine("\t{0}", el.Key);
            }

            ent = entities[entities.Count - 1];

            Console.WriteLine("ent:\n{0}", ent);

            Console.WriteLine(new string('=', Console.BufferWidth - 1));

            List<object> objects = new List<object>()
            {
                obj1, obj2, obj3, ent
            };

            Console.WriteLine("objects:");

            foreach (var el in objects)
            {
                Console.WriteLine("{0}", el);
            }

            Service service1 = new Service("Заміна масла", 500, TimeSpan.FromHours(1), TimeSpan.FromDays(30)) { Id = 1 };
            Maintenance maintenance1 = new Maintenance(obj1, service1, DateTime.Now, 500, "Заміна масла та фільтра") { Id = 1 };

            Service service2 = new Service("Ремонт двигуна", 10000, TimeSpan.FromDays(3), TimeSpan.FromDays(365)) { Id = 2 };
            Maintenance maintenance2 = new Maintenance(obj2, service2, DateTime.Now, 10000, "Капітальний ремонт двигуна") { Id = 2 };

            Console.WriteLine("maintenance1:\n{0}", maintenance1);
            Console.WriteLine(new string('=', Console.BufferWidth - 1));
            Console.WriteLine("maintenance2:\n{0}", maintenance2);
        }
    }
}