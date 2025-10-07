using Common.Interfaces;
using Common.Processing.Events;
using Common.Processing.Types;
using System;
using System.Collections.Generic;

namespace Common.Processing.Interfaces {
    public interface IEntityEditor<TModel> where TModel : class, IIdentifiable, IKeyable {

        IEnumerable<TModel> GetModels();

        void RunAction(CrudMode mode, TModel model);
        void Save();

        event EventHandler<ActionInfoEventArgs> ActionError;
        event EventHandler<EventArgs> DataChanged;
    }
}