using Autoservice.Processing.Interfaces;
using Common.Processing.Editing;

namespace Autoservice.Processing.Editing
{
    public class OwnersEditingController : EntityEditingController<OwnerModel>
    {
        new protected readonly IOwnerEditor _editor;
        new protected readonly IOwnersEditingView _view;

        public OwnersEditingController(IOwnerEditor editor, IOwnersEditingView view)
            : base(editor, view)
        {
            _editor = editor;
            _view = view;
        }

        protected override void SetSelectionListsItems()
        {
    
        }
    }
}