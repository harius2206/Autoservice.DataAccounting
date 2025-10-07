using Common.Interfaces;
using Common.Processing.Events;
using System;
using System.Collections.Generic;

namespace Common.Processing.Interfaces {
    public interface IEditingView<TModel> where TModel : class, IIdentifiable, IKeyable {

        event EventHandler<CrudActionEventArgs> CrudAction;
        event EventHandler<EventArgs> TestingDataCreation;

        void UpdateInfo(List<TModel> models);
    }
}
