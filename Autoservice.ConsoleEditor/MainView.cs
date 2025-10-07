using Common.ConsoleUI;
using System;
using System.Linq;
using Autoservice.ConsoleEditor.Views;
using Autoservice.UI.Formatting;

namespace Autoservice.ConsoleEditor
{
    internal class MainView : BaseCommandController
    {
        protected ModelsListsSet _modelsListsSet = new ModelsListsSet();

        public OwnersEditingView OwnersEditingView { get; set; }
        public TransportsEditingView TransportsEditingView { get; set; }
        public ServicesEditingView ServicesEditingView { get; set; }
        public MeintenanceEditingView MeintenanceEditingView { get; set; }

        public event EventHandler<EventArgs> TestingDataCreation;
        public event EventHandler<EventArgs> DataClearing;
        public event EventHandler<EventArgs> DataSaving;
        public event EventHandler<EventArgs> DataLoadingEvent;
        public event EventHandler ShowAsTextCompleted;

        protected override MenuItemEx[] IniMenuItems()
        {
            return new MenuItemEx[]
            {
                new MenuItemEx("вийти", null),
                new MenuItemEx("створити тестові дані", CreateTestingData, false, () => _modelsListsSet.IsEmpty()),
                new MenuItemEx("дані як текст", ShowAsText, true, ListsSetIsNotEmpty),
                new MenuItemEx("видалити усі дані", Clear, false, ListsSetIsNotEmpty),
                new MenuItemEx("зберегти дані", Save, stopping: true, displayed: ListsSetIsNotEmpty),
                new MenuItemEx("редагування власників ►", RunOwnersEditing, false, ListsSetIsNotEmpty),
                new MenuItemEx("редагування транспорту ►", RunTransportsEditing, false, ListsSetIsNotEmpty),
                new MenuItemEx("редагування послуг ►", RunServicesEditing, false, ListsSetIsNotEmpty),
                new MenuItemEx("редагування обслуговувань ►", RunMeintenanceEditing, false, ListsSetIsNotEmpty),
            };
        }

        private bool ListsSetIsNotEmpty() => _modelsListsSet != null && !_modelsListsSet.IsEmpty();

        public void UpdateInfo(ModelsListsSet modelsListsSet)
        {
            _modelsListsSet = modelsListsSet ?? new ModelsListsSet();
        }

        protected override void PrepareScreen()
        {
            Console.Clear();
            Console.WriteLine("ПО \"СТО\"\n");
            Console.WriteLine(_modelsListsSet.ToStatisticsString());
        }

        private bool CheckEvent(string commandName, EventHandler<EventArgs> _event)
        {
            if (_event == null)
            {
                Console.WriteLine($"\n  Команда {commandName} не підтримується");
                StopToView();
                return false;
            }
            return true;
        }

        private void CreateTestingData()
        {
            if (CheckEvent("створення тестових даних", TestingDataCreation))
                TestingDataCreation(this, EventArgs.Empty);
        }

        private void ShowAsText()
        {
            Console.WriteLine();
            Console.WriteLine(_modelsListsSet.ToDataString());
            ShowAsTextCompleted?.Invoke(this, EventArgs.Empty);
        }

        private void Clear()
        {
            if (CheckEvent("видалення усіх даних", DataClearing))
                DataClearing(this, EventArgs.Empty);
        }

        private void Save()
        {
            if (CheckEvent("збереження даних", DataSaving))
                DataSaving(this, EventArgs.Empty);
        }

        protected override void PrepareRunning()
        {
            if (CheckEvent("завантаження даних", DataLoadingEvent))
                DataLoadingEvent(this, EventArgs.Empty);
        }

        private void RunOwnersEditing()
        {
            OwnersEditingView?.Run();
        }

        private void RunTransportsEditing()
        {
            TransportsEditingView?.Run();
        }

        private void RunServicesEditing()
        {
            ServicesEditingView?.Run();
        }

        private void RunMeintenanceEditing()
        {
            MeintenanceEditingView?.Run();
        }
    }
}