using Common.Processing.Types;
using System;

namespace Common.Processing.Events {
    public class ActionInfoEventArgs : EventArgs {
        public readonly CrudMode CrudMode;
        public readonly string EntityTypeName;
        public readonly object Model;
        public readonly string Message;

        public ActionInfoEventArgs(CrudMode crudMode, string entityTypeName, 
            object model, string message) {

            CrudMode = crudMode;
            EntityTypeName = entityTypeName;
            Model = model;
            Message = message;
        }
    }
}
