using System;
using System.IO;
using Common.ConsoleIO;
using System.Text;
using Autoservice.DataAccounting.UI;
using Autoservice.UI.Formatting.Simple;
using Autoservice.UI.Formatting;
using Autoservice.UI.Searching;


namespace Autoservice.DataAccounting.Browsing
{
    internal partial class SimpleBrowser
    {
        private SimpleMenuItem[] _menuItems;
        private ModelsListsSet _listsSet = new ModelsListsSet();

        public string DirectoryName { get; set; } = "";
        public string FileName { get; set; } = "WorldDividing.txt";

        //public DataFileIoController _dataFileIoController = new DataFileIoController();

        //private void IniMenuItems()
        //{
        //    _menuItems = new SimpleMenuItem[] {
        //        new SimpleMenuItem("вийти", null),
        //        new SimpleMenuItem("створити тестові дані", CreateTestingData),
        //        new SimpleMenuItem("видалити усі дані", DeleteData),
        //        new SimpleMenuItem("дані як текст", ShowAsText),
        //        new SimpleMenuItem("зберегти дані як текст...", SaveAsText),
        //        new SimpleMenuItem("детально про власника...", ShowOwnerDetails),
        //        new SimpleMenuItem("детально про послугу...", ShowServiceDetails),
        //        new SimpleMenuItem("сортувати власників за ім'ям", SortByName),
        //        new SimpleMenuItem("сортувати власників за електронною поштою", SortByEmail),
        //        new SimpleMenuItem("сортувати власників за адресою", SortByAddress),
        //        new SimpleMenuItem("сортувати послуги за назвою", SortByServiceName),
        //        new SimpleMenuItem("сортувати послуги за ціною", SortByServicePrice),
        //        new SimpleMenuItem("сортувати послуги за тривалістю", SortByServiceDuration),
        //        new SimpleMenuItem("зберегти дані", Save), // Додано новий пункт меню для збереження даних
        //        new SimpleMenuItem("завантажити дані", Load) // Додано новий пункт меню для завантаження даних
        //    };
        //}

        //public SimpleBrowser()
        //{
        //    IniMenuItems();
        //}

        public SimpleMenuItem SelectMenuItem()
        {
            Console.WriteLine("\n Список команд меню:");
            for (int i = 0; i < _menuItems.Length; i++)
            {
                Console.WriteLine("\t{0,2} - {1}", i, _menuItems[i].CommandName);
            }
            int number = Inputting.InputInt32("\n Введіть номер команди меню", 0, _menuItems.Length - 1);
            return _menuItems[number];
        }

        private static void StopToView()
        {
            Console.WriteLine("\tДля продовження натисніть довільну клавішу...");
            Console.ReadKey(true);
        }

        //public void Run()
        //{
        //    Load();
        //    ConsoleSettings.SetConsoleParam();
        //    while (true)
        //    {
        //        PrepareScreen();
        //        SimpleMenuItem menuItem = SelectMenuItem();
        //        if (menuItem.Operation == null)
        //        {
        //            return;
        //        }
        //        try
        //        {
        //            menuItem.Operation();
        //            StopToView();
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //            StopToView();
        //        }
        //    }
        //}

        //private void PrepareScreen()
        //{
        //    Console.Clear();
        //    Console.WriteLine("ПО \"Автосервіс\"");
        //    Console.WriteLine(DataFormatting.ToStatisticsString(_listsSet));
        //    if (!_listsSet.IsEmpty())
        //    {
        //        Console.WriteLine();
        //        Console.WriteLine(SimpleTablesFormatting.ToTable(_listsSet.OwnerModels));
        //        Console.WriteLine();
        //        Console.WriteLine(SimpleTablesFormatting.ToTable(_listsSet.ServiceModels));

        //    }
        //}

        //private void CreateTestingData()
        //{
        //    if (!ModelsCreation.CreateTestingModels(_listsSet))
        //    {
        //        Console.WriteLine("\nТестові дані не створені, оскільки сховище не порожнє.");
        //        StopToView();
        //    }
        //}

        private void DeleteData()
        {
            _listsSet.Clear();
        }

        private void ShowAsText()
        {
            Console.WriteLine();
            Console.Write(DataFormatting.ToDataString(_listsSet));
        }

        private void SaveAsText()
        {
            Console.Write("\tІм'я файлу: ");
            string fileName = Console.ReadLine();
            string directoryName = Path.GetDirectoryName(fileName);
            if (!string.IsNullOrWhiteSpace(directoryName) && !Directory.Exists(directoryName))
            {
                Directory.CreateDirectory(directoryName);
            }
            string data = DataFormatting.ToDataString(_listsSet);
            File.WriteAllText(fileName, data, Encoding.Unicode);
            Console.WriteLine("Дані збережено у файл: " + fileName);
        }

        private void ShowOwnerDetails()
        {
            int id = Inputting.InputInt32(" Введіть Id власника");
            OwnerModel ownerModel = ModelsSearching.ById(_listsSet.OwnerModels, id);
            if (ownerModel == null)
            {
                Console.WriteLine(" В списку власників немає запису з Id рівним {0}", id);
                StopToView();
                return;
            }
            Console.WriteLine(ownerModel.ToDataString());
            StopToView();
        }

        private void ShowServiceDetails()
        {
            int id = Inputting.InputInt32(" Введіть Id сервіса");
            ServiceModel serviceModel = ModelsSearching.ById(_listsSet.ServiceModels, id);
            if (serviceModel == null)
            {
                Console.WriteLine(" В списку сервісів немає запису з Id рівним {0}", id);
                StopToView();
                return;
            }
            Console.WriteLine(serviceModel.ToDataString());
            StopToView();
        }

        //private void Save()
        //{
        //    string filePath = Path.Combine(DirectoryName, FileName);
        //    DataFileIoController.Save(_listsSet, filePath);
        //    Console.WriteLine("Дані збережено");
        //    StopToView();
        //}

        //private void Load()
        //{
        //    string filePath = Path.Combine(DirectoryName, FileName);
        //    if (_dataFileIoController.Load(_listsSet, filePath))
        //    {
        //        Console.WriteLine("Дані завантажено");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Файл з даними відсутній");
        //    }
        //    StopToView();
        //}
    }
}