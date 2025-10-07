using Common.Interfaces;
using Common.Processing.Events;
using Common.Processing.Interfaces;
using Common.Processing.Types;
using System;
using System.Linq;

namespace Common.Processing.Editing
{
    public abstract class EntityEditingController<TModel> : IEditingController
        where TModel : class, IIdentifiable, IKeyable
    {

        protected readonly IEntityEditor<TModel> _editor;
        protected readonly IEditingView<TModel> _view;

        public EntityEditingController(IEntityEditor<TModel> editor, IEditingView<TModel> view)
        {
            //
            _editor = editor;
            _view = view;
            SetHandlers();
        }

        private void SetHandlers()
        {
            _editor.DataChanged += Editor_DataChanged;
            _editor.ActionError += Editor_ActionError;
            //_view.DataSaving += View_DataSaving;
            _view.CrudAction += View_CrudAction;
        }


        private void Editor_DataChanged(object sender, EventArgs e)
        {
            UpdateView();
        }

        public void UpdateView()
        {
            SetSelectionListsItems();
            _view.UpdateInfo(_editor.GetModels().ToList());
        }

        protected abstract void SetSelectionListsItems();

        private void Editor_ActionError(object sender, ActionInfoEventArgs e)
        {
          
            Console.WriteLine($"[ПОМИЛКА] {e.Message}");
            Console.WriteLine("Натисніть будь-яку клавішу для продовження...");
            Console.ReadKey(true);
        }

        private void View_CrudAction(object sender, CrudActionEventArgs e)
        {
            //SetViewParams(e.CrudMode, e.KeyableObject);
            RunAction(e.CrudMode, e.KeyableObject);
        }

        void RunAction(CrudMode mode, IKeyable keyableObject)
        {
            TModel model = (keyableObject as TModel);
            _editor.RunAction(mode, model);
        }

        private void View_DataSaving(object sender, CancelingEventArgs e)
        {
            _editor.Save();
        }
    }
}
