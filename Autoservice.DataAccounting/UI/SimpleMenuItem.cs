using System;

namespace Autoservice.DataAccounting.UI
{
    internal struct SimpleMenuItem
    {
        public string CommandName;

        public Action Operation;
        public SimpleMenuItem(string commandName, Action operation)
        {
            this.CommandName = commandName;
            this.Operation = operation;
        }
    }
}