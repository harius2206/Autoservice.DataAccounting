using Autoservice.Processing.Interfaces;
using Common.ConsoleUI.Views;
using Autoservice.UI.Settings.Tables;
using System;
using System.Collections.Generic;

namespace Autoservice.ConsoleEditor.Views
{
    internal class MeintenanceEditingView : EditingView<MeintenanceModel>, IMeintenanceEditingView
    {
        private string[] _transportKeys;
        private string[] _serviceKeys;

        public void UpdateTransportSelectionList(string[] items)
        {
            _transportKeys = items;
        }

        public void UpdateServiceSelectionList(string[] items)
        {
            _serviceKeys = items;
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
                    Console.WriteLine($"Id: {model.Id}, TransportKey: {model.TransportKey}, ServiceKey: {model.ServiceKey}, Date: {model.Date:yyyy-MM-dd}, Cost: {model.Cost}");
                }
            }
            else
            {
                Console.WriteLine("Список моделей пуст.");
            }
        }

        protected override void ShowObjectDetails(MeintenanceModel model)
        {
            Console.WriteLine($"Id: {model.Id}, TransportKey: {model.TransportKey}, ServiceKey: {model.ServiceKey}, Date: {model.Date:yyyy-MM-dd}, Cost: {model.Cost}");
        }

        protected override void Create(out MeintenanceModel model)
        {
            model = new MeintenanceModel();
            Console.WriteLine("Введіть дані обслуговування");

            model.TransportKey = _transportKeys != null && _transportKeys.Length > 0
                ? SelectFromList(_transportKeys, "Виберіть транспорт")
                : InputString("Ключ транспорту");

            model.ServiceKey = _serviceKeys != null && _serviceKeys.Length > 0
                ? SelectFromList(_serviceKeys, "Виберіть послугу")
                : InputString("Ключ послуги");

            Console.Write("Дата (yyyy-MM-dd): ");
            if (DateTime.TryParse(Console.ReadLine(), out var date))
                model.Date = date;
            else
                model.Date = null;

            Console.Write("Вартість: ");
            if (decimal.TryParse(Console.ReadLine(), out var cost))
                model.Cost = cost;
            else
                model.Cost = null;
        }

        protected override void Update(MeintenanceModel model)
        {
            Console.WriteLine("Редагування обслуговування (залиште порожнім для збереження старого значення)");

            Console.Write($"Ключ транспорту [{model.TransportKey}]: ");
            var input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
                model.TransportKey = input;

            Console.Write($"Ключ послуги [{model.ServiceKey}]: ");
            input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
                model.ServiceKey = input;

            Console.Write($"Дата [{model.Date:yyyy-MM-dd}]: ");
            input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input) && DateTime.TryParse(input, out var date))
                model.Date = date;

            Console.Write($"Вартість [{model.Cost}]: ");
            input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input) && decimal.TryParse(input, out var cost))
                model.Cost = cost;
        }

        private string SelectFromList(string[] items, string prompt)
        {
            Console.WriteLine(prompt);
            for (int i = 0; i < items.Length; i++)
                Console.WriteLine($"{i + 1}. {items[i]}");
            Console.Write("Виберіть номер: ");
            if (int.TryParse(Console.ReadLine(), out int idx) && idx > 0 && idx <= items.Length)
                return items[idx - 1];
            return items.Length > 0 ? items[0] : null;
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
    Console.WriteLine("2. За ключем транспорту");
    Console.WriteLine("3. За ключем сервісу");
    Console.WriteLine("4. За датою");
    Console.WriteLine("5. За вартістю");
    Console.WriteLine("6. За нотаткою");
    Console.WriteLine("7. За ключем (Key)");
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
            Models.Sort((m1, m2) => string.Compare(m1.TransportKey, m2.TransportKey, StringComparison.CurrentCulture));
            break;
        case '3':
            Models.Sort((m1, m2) => string.Compare(m1.ServiceKey, m2.ServiceKey, StringComparison.CurrentCulture));
            break;
        case '4':
            Models.Sort((m1, m2) => Nullable.Compare(m1.Date, m2.Date));
            break;
        case '5':
            Models.Sort((m1, m2) => Nullable.Compare(m1.Cost, m2.Cost));
            break;
        case '6':
            Models.Sort((m1, m2) => string.Compare(m1.Note, m2.Note, StringComparison.CurrentCulture));
            break;
        case '7':
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