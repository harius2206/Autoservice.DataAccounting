using Autoservice.Processing.Interfaces;
using Common.ConsoleUI.Views;
using Autoservice.UI.Settings.Tables;
using System;
using System.Collections.Generic;
using Common.ConsoleUI.Selection;

namespace Autoservice.ConsoleEditor.Views
{
    internal class TransportsEditingView : EditingView<TransportModel>, ITransportsEditingView
    {
        private string[] _vlasnukSelectionItems;
        private string[] _parentSelectionItems;

        public void UpdateParentSelectionList(string[] names)
        {
            _parentSelectionItems = names;
        }

        public void UpdateVlasnukSelectionList(string[] keys)
        {
            _vlasnukSelectionItems = keys;
        }

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
                    Console.WriteLine($"Id: {model.Id}, Make: {model.Make}, Model: {model.Model}, Number: {model.Number}, Owner: {model.OwnerKey}, Parent: {model.ParentKey}, Description: {model.Description}");
                }
            }
            else
            {
                Console.WriteLine("Список моделей пуст.");
            }
        }

        protected override void ShowObjectDetails(TransportModel model)
        {
            Console.WriteLine($"Id: {model.Id}, Make: {model.Make}, Model: {model.Model}, Number: {model.Number}, Owner: {model.OwnerKey}, Parent: {model.ParentKey}, Description: {model.Description}");
        }

        protected override void Create(out TransportModel model)
        {
            model = new TransportModel();
            Console.WriteLine("Введіть дані транспорту:");
            model.Make = InputString("Марка");
            model.Model = InputString("Модель");
            model.Number = InputString("Номер");
            model.OwnerKey = _vlasnukSelectionItems
                            .SelectItem("Виберіть власника");
            model.ParentKey = _parentSelectionItems.SelectItem(
                "Виберіть батьківський транспорт (залиште порожнім, якщо немає)");
            model.Description = InputString("Опис");


        }
        protected override void Update(TransportModel model)
        {
            Console.WriteLine("Редагування транспорту (залиште порожнім для збереження старого значення)");

            Console.Write($"Марка [{model.Make}]: ");
            var input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
                model.Make = input;

            Console.Write($"Модель [{model.Model}]: ");
            input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
                model.Model = input;

            Console.Write($"Номер [{model.Number}]: ");
            input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
                model.Number = input;

            Console.Write($"Опис [{model.Description}]: ");
            input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
                model.Description = input;

          
        }

        private string InputString(string prompt)
        {
            Console.Write($"{prompt}: ");
            return Console.ReadLine();
        }
        protected override void SortMenu()
        {
            Console.WriteLine("Сортування:");
            Console.WriteLine("1. За Id");
            Console.WriteLine("2. За маркою");
            Console.WriteLine("3. За моделлю");
            Console.WriteLine("4. За номером");
            Console.WriteLine("5. За описом");
            Console.WriteLine("6. За власником");
            Console.WriteLine("7. За батьківським транспортом");
            Console.WriteLine("8. За ключем");
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
                    Models.Sort((m1, m2) => string.Compare(m1.Make, m2.Make, StringComparison.CurrentCulture));
                    break;
                case '3':
                    Models.Sort((m1, m2) => string.Compare(m1.Model, m2.Model, StringComparison.CurrentCulture));
                    break;
                case '4':
                    Models.Sort((m1, m2) => string.Compare(m1.Number, m2.Number, StringComparison.CurrentCulture));
                    break;
                case '5':
                    Models.Sort((m1, m2) => string.Compare(m1.Description, m2.Description, StringComparison.CurrentCulture));
                    break;
                case '6':
                    Models.Sort((m1, m2) => string.Compare(m1.OwnerKey, m2.OwnerKey, StringComparison.CurrentCulture));
                    break;
                case '7':
                    Models.Sort((m1, m2) => string.Compare(m1.ParentKey, m2.ParentKey, StringComparison.CurrentCulture));
                    break;
                case '8':
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