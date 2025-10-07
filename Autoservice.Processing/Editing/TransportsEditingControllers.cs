using Autoservice.Processing.Interfaces;
using Common.Processing.Editing;
using System.Linq;

namespace Autoservice.Processing.Editing
{
    public class TransportsEditingController : EntityEditingController<TransportModel>
    {
        new protected readonly ITransportsEditor _editor;
        new protected readonly ITransportsEditingView _view;
      
        public TransportsEditingController(ITransportsEditor editor, ITransportsEditingView view)
            : base(editor, view)
        {
            _editor = editor;
            _view = view;
        }

        protected override void SetSelectionListsItems()
        {
            _view.CrudAction += (s, e) => _editor.RunAction(e.CrudMode, (TransportModel)e.KeyableObject);
            _view.UpdateParentSelectionList(_editor.ParentSelectionItems.ToArray());
            _view.UpdateVlasnukSelectionList(_editor.VlasnukSelectionItems.ToArray());
        }
    }
}