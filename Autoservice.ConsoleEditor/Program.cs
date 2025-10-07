using Common.ConsoleIO;
using System;
using System.Linq;
using Autoservice.ConsoleEditor.Views;
using Autoservice.Data;
using Autoservice.Data.IO;
using Autoservice.Processing.Converting;
using Autoservice.Processing.Editing;

namespace Autoservice.ConsoleEditor
{
    internal class Program
    {
        static MainView _mainView = null;

        static XmlFileIoController _xmlFileIoController = null;
        static BinaryFileIoController _binaryFileIoController = null;
        static DataContext _dataContext = null;

        static OwnersEditingView _ownersEditingView = null;
        static TransportsEditingView _transportsEditingView = null;
        static ServicesEditingView _servicesEditingView = null;
        static MeintenanceEditingView _meintenanceEditingView = null;

        static MaintancesEditor _maintancesEditor = null;
        static MaintancesEditingController _maintancesEditingController = null;

        static TransportsEditor _transportsEditor = null;
        static TransportsEditingController _transportsEditingController = null;

        static OwnersEditor _ownersEditor = null;
        static OwnersEditingController _ownersEditingController = null;

        static ServicesEditor _servicesEditor = null;
        static ServicesEditingController _servicesEditingController = null;

        static void Main(string[] args)
        {
            Console.Title = "Autoservice.ConsoleEditor";
            ConsoleSettings.SetConsoleParam();
            Console.WriteLine(" Реалізація консольного редактора даних ПО \"СТО\"");
            RunProgram();
        }

        private static void RunProgram()
        {
            _xmlFileIoController = new XmlFileIoController();
            _binaryFileIoController = new BinaryFileIoController();
            _dataContext = new DataContext(_binaryFileIoController);
            _dataContext.DirectoryName = @"..\..\files";

            _ownersEditingView = new OwnersEditingView();
            _transportsEditingView = new TransportsEditingView();
            _servicesEditingView = new ServicesEditingView();
            _meintenanceEditingView = new MeintenanceEditingView();

            _maintancesEditor = new MaintancesEditor(_dataContext);
            _maintancesEditingController = new MaintancesEditingController(_maintancesEditor, _meintenanceEditingView);

            _transportsEditor = new TransportsEditor(_dataContext);
            _transportsEditingController = new TransportsEditingController(_transportsEditor, _transportsEditingView);

            _ownersEditor = new OwnersEditor(_dataContext);
            _ownersEditingController = new OwnersEditingController(new OwnersEditor(_dataContext), _ownersEditingView);

            _servicesEditor = new ServicesEditor(_dataContext);
            _servicesEditingController = new ServicesEditingController(_servicesEditor, _servicesEditingView);

            _mainView = new MainView
            {
                OwnersEditingView = _ownersEditingView,
                TransportsEditingView = _transportsEditingView,
                ServicesEditingView = _servicesEditingView,
                MeintenanceEditingView = _meintenanceEditingView
            };

            SetHandlers();
            _mainView.Run();
        }

        private static void SetHandlers()
        {
            _mainView.TestingDataCreation += MainView_TestingDataCreation;
            _dataContext.DataChanged += DataChanged;
            _mainView.DataClearing += MainView_DataClearing;
            _mainView.DataSaving += MainView_DataSaving;
            _mainView.DataLoadingEvent += MainView_DataLoading;

            _maintancesEditor.DataChanged += DataChanged;
            _transportsEditor.DataChanged += DataChanged;

            _mainView.ShowAsTextCompleted += MainView_ShowAsTextCompleted;
        }

        private static void MainView_TestingDataCreation(object sender, EventArgs e)
        {
            _dataContext.CreateTestingData();
        }

        private static void DataChanged(object sender, EventArgs e)
        {
            ModelsListsSet modelsListsSet = _dataContext.ToModelsListsSet();
            _mainView.UpdateInfo(modelsListsSet);

            _ownersEditingView.UpdateInfo(modelsListsSet.OwnerModels);
            _transportsEditingView.UpdateInfo(modelsListsSet.TransportModels);
            _servicesEditingView.UpdateInfo(modelsListsSet.ServiceModels);
            _meintenanceEditingView.UpdateInfo(modelsListsSet.MeintenanceModels);

            _transportsEditingView.UpdateParentSelectionList(
                modelsListsSet.TransportModels.Select(t => t.ParentKey).ToArray());
            _transportsEditingView.UpdateVlasnukSelectionList(
                modelsListsSet.OwnerModels.Select(t => t.Key).ToArray());
            _servicesEditingView.UpdateParentSelectionList(
                modelsListsSet.ServiceModels.Select(s => s.Name).ToArray());
            _meintenanceEditingView.UpdateTransportSelectionList(
                modelsListsSet.TransportModels.Select(t => t.Key).ToArray());
            _meintenanceEditingView.UpdateServiceSelectionList(
                modelsListsSet.ServiceModels.Select(s => s.Key).ToArray());
        }

        private static void MainView_DataClearing(object sender, EventArgs e)
        {
            _dataContext.Clear();
        }

        private static void MainView_DataSaving(object sender, EventArgs e)
        {
            _dataContext.Save();
        }

        private static void MainView_DataLoading(object sender, EventArgs e)
        {
            if (_dataContext.Load())
            {
                Console.WriteLine("Дані завантажено");
            }
            else
            {
                Console.WriteLine("Файл з даними відсутній");
            }
        }

        private static void MainView_ShowAsTextCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("\nНатисніть будь-яку клавішу для повернення до меню...");
            Console.ReadKey(true);
        }
    }
}