using Autoservice.Processing.Interfaces;
using Common.ConsoleUI.Views;
using Autoservice.UI.Settings.Tables;
using System;
using System.Collections.Generic;

namespace Autoservice.ConsoleEditor.Views
{
    internal class ServicesEditingView : EditingView<ServiceModel>, IServicesEditingView
    {
        protected override void OutTable()
        {
            Console.WriteLine(Models.ToTable());
        }

        protected override void ShowAsText()
        {
            Console.WriteLine();
            if (Models != null && Models.Count > 0)
            {
                foreach (var model in Models)
                {
                    Console.WriteLine($"Id: {model.Id}, Name: {model.Name}, Price: {model.Price}, Duration: {model.Duration}, Periodicity: {model.WarrantyPeriod}, Key: {model.Key}");
                }
            }
            else
            {
                Console.WriteLine("Список сервісів пустий.");
            }
        }

        protected override void ShowObjectDetails(ServiceModel model)
        {
            Console.WriteLine($"Id: {model.Id}, Name: {model.Name}, Price: {model.Price}, Duration: {model.Duration}, Periodicity: {model.WarrantyPeriod}, Key: {model.Key}");
        }

        protected override void Create(out ServiceModel model)
        {
            model = new ServiceModel();
            Console.WriteLine("Введіть дані сервісу:");
            Console.Write("Назва: ");
            model.Name = Console.ReadLine();
            Console.Write("Ціна: ");
            if (decimal.TryParse(Console.ReadLine(), out var price))
                model.Price = price;
            else
                model.Price = 0;
            Console.Write("Тривалість (години): ");
            if (double.TryParse(Console.ReadLine(), out var hours))
                model.Duration = TimeSpan.FromHours(hours);
            else
                model.Duration = TimeSpan.Zero;
            Console.Write("Періодичність (дні): ");
            if (double.TryParse(Console.ReadLine(), out var days))
                model.WarrantyPeriod = TimeSpan.FromDays(days);
            else
                model.WarrantyPeriod = TimeSpan.Zero;
            model.Key = Guid.NewGuid().ToString();
        }

        protected override void Update(ServiceModel model)
        {
            Console.WriteLine("Редагування сервісу (залиште порожнім для збереження старого значення)");

            Console.Write($"Назва [{model.Name}]: ");
            var input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
                model.Name = input;

            Console.Write($"Ціна [{model.Price}]: ");
            input = Console.ReadLine();
            if (decimal.TryParse(input, out var price))
                model.Price = price;

            Console.Write($"Тривалість (години) [{model.Duration}]: ");
            input = Console.ReadLine();
            if (double.TryParse(input, out var hours))
                model.Duration = TimeSpan.FromHours(hours);

            Console.Write($"Періодичність (дні) [{model.WarrantyPeriod}]: ");
            input = Console.ReadLine();
            if (double.TryParse(input, out var days))
                model.WarrantyPeriod = TimeSpan.FromDays(days);
        }

        public void UpdateParentSelectionList(string[] names)
        {
        }
        protected override void SortMenu()
        {
            Console.WriteLine("Сортування:");
            Console.WriteLine("1. За Id");
            Console.WriteLine("2. За назвою");
            Console.WriteLine("3. За ціною");
            Console.WriteLine("4. За тривалістю");
            Console.WriteLine("5. За періодичністю");
            Console.WriteLine("6. За ключем");
            Console.WriteLine("0. Назад");
            Console.Write("Оберіть опцію: ");
            var key = Console.ReadKey(true).KeyChar;
            bool sorted = true;
            switch (key)
            {
                case '1':
                    Models.Sort((m1, m2) => m1.Id.CompareTo(m2.Id));
                    break;
                case '2':
                    Models.Sort((m1, m2) => string.Compare(m1.Name, m2.Name, StringComparison.CurrentCulture));
                    break;
                case '3':
                    Models.Sort((m1, m2) => Nullable.Compare(m1.Price, m2.Price));
                    break;
                case '4':
                    Models.Sort((m1, m2) => Nullable.Compare(m1.Duration, m2.Duration));
                    break;
                case '5':
                    Models.Sort((m1, m2) => Nullable.Compare(m1.WarrantyPeriod, m2.WarrantyPeriod));
                    break;
                case '6':
                    Models.Sort((m1, m2) => string.Compare(m1.Key, m2.Key, StringComparison.CurrentCulture));
                    break;
                case '0':
                    sorted = false;
                    break;
                default:
                    sorted = false;
                    break;
            }
            if (sorted)
            {
                Console.WriteLine("Відсортовано!");
                Console.WriteLine("Натисніть будь-яку клавішу для продовження...");
                Console.ReadKey(true);
            }
        }
    }
}