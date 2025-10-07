using Common.Interfaces;
using System;

namespace Common.ConsoleUI {
    public class MenuItemEx : MenuItem, IKeyable {

        public Func<bool> Displayed;
        public object Tag;

        public MenuItemEx(string commandName, Action operation, bool stopping = false, 
            Func<bool> displayed = null, object tag = null) 
            : base(commandName, operation, stopping) {

            this.Displayed = displayed;
            this.Tag = tag;
        }

        public string Key => CommandName;
    }
}
