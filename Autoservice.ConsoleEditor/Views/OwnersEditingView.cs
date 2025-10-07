using Autoservice.Processing.Interfaces;
using Common.ConsoleUI.Views;
using Autoservice.UI.Settings.Tables;
using System;
using System.Collections.Generic;

namespace Autoservice.ConsoleEditor.Views
{
    internal class OwnersEditingView : EditingView<OwnerModel>, IOwnersEditingView
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
                    Console.WriteLine($"Id: {model.Id}, Name: {model.Name}, Email: {model.Email}, Address: {model.Address}");
                }
            }
            else
            {
                Console.WriteLine("Список моделей пуст.");
            }
        }

        protected override void ShowObjectDetails(OwnerModel model)
        {
            Console.WriteLine($"Id: {model.Id}, Name: {model.Name}, Email: {model.Email}, Address: {model.Address}");
        }

        protected override void Create(out OwnerModel model)
        {
            model = new OwnerModel();
            Console.WriteLine("Введіть дані власника:");

            model.Name = InputString("Ім'я");
            model.Email = InputString("E-mail");
            model.Address = InputString("Адреса");

            model.Key = Guid.NewGuid().ToString();
        }

        protected override void Update(OwnerModel model)
        {
            Console.WriteLine("Оновлення даних власника (залиште порожнім для збереження старого значення):");

            var input = InputUpdate("Ім'я", model.Name);
            if (!string.IsNullOrWhiteSpace(input)) model.Name = input;

            input = InputUpdate("E-mail", model.Email);
            if (!string.IsNullOrWhiteSpace(input)) model.Email = input;

            input = InputUpdate("Адреса", model.Address);
            if (!string.IsNullOrWhiteSpace(input)) model.Address = input;
        }

        private string InputString(string prompt)
        {
            Console.Write($"{prompt}: ");
            return Console.ReadLine();
        }

        private string InputUpdate(string prompt, string oldValue)
        {
            Console.Write($"{prompt} [{oldValue}]: ");
            return Console.ReadLine();
        }

        public void UpdateParentSelectionList(string[] parentKeys)
        {
        }

        private string ToOwnersTable(IList<OwnerModel> owners)
        {
            if (owners == null || owners.Count == 0)
                return "Список власників порожній.";

            var header = $"| {"Id",4} | {"Name",-20} | {"Email",-25} | {"Address",-30} |";
            var separator = new string('-', header.Length);
            var rows = new List<string> { separator, header, separator };
            foreach (var o in owners)
            {
                rows.Add($"| {o.Id,4} | {o.Name,-20} | {o.Email,-25} | {o.Address,-30} |");
            }
            rows.Add(separator);
            return string.Join(Environment.NewLine, rows);
        }

        protected override void SortMenu()
        {
            Console.WriteLine("Сортування:");
            Console.WriteLine("1. За Id");
            Console.WriteLine("2. За іменем");
            Console.WriteLine("3. За email");
            Console.WriteLine("4. За адресою");
            Console.WriteLine("5. За ключем");
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
                    Models.Sort((m1, m2) => string.Compare(m1.Email, m2.Email, StringComparison.CurrentCulture));
                    break;
                case '4':
                    Models.Sort((m1, m2) => string.Compare(m1.Address, m2.Address, StringComparison.CurrentCulture));
                    break;
                case '5':
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