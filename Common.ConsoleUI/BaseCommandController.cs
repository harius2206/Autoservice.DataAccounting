using Common.ConsoleIO;
using System;

namespace Common.ConsoleUI {
    public abstract class BaseCommandController {
       
        private MenuItemEx[] _menuItems;

        protected abstract MenuItemEx[] IniMenuItems();

        protected virtual void PrepareRunning() { }
        protected abstract void PrepareScreen();

        public BaseCommandController() {
            _menuItems = IniMenuItems();
        }

        public bool OneCommandOnly { get; set; }

        public object Tag { get; set; }

        public void Run() {
            PrepareRunning();
            while (true) {
                PrepareScreen();
                MenuItemEx menuItem = MenuItemSelector.Invoke(_menuItems);
                //if (menuItem == null) {
                //    return;
                //}
                Tag = menuItem.Tag;
                if (menuItem.Operation == null) {
                    return;
                }
                try {
                    menuItem.Operation();
                    if (menuItem.Stopping) {
                        StopToView();
                    }
                    if (OneCommandOnly) {
                        return;
                    }
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                    StopToView();
                }
            }
        }

        private Func<MenuItemEx[], MenuItemEx> _menuItemSelector;

        public Func<MenuItemEx[], MenuItemEx> MenuItemSelector {
            get {
                if (_menuItemSelector == null) {
                    _menuItemSelector = SelectMenuItem;
                }
                return _menuItemSelector;
            }
            set { _menuItemSelector = value; }
        }

        public static MenuItemEx SelectMenuItem(MenuItemEx[] menuItems) {
            Console.WriteLine("\n Список команд меню:");
            for (int i = 0; i < menuItems.Length; i++) {
                if (menuItems[i].Displayed == null || menuItems[i].Displayed()) {
                    Console.WriteLine("\t{0,2} - {1}", i, menuItems[i].CommandName);
                }
            }
            int number = Inputting.InputInt32(
                "\n Введіть номер команди меню", 0, menuItems.Length - 1);
            return menuItems[number];
        }


        public static void StopToView() {
            Console.Write("\n\tДля продовження натисніть довільну клавішу...");
            Console.ReadKey(true);
        }

    }
}
