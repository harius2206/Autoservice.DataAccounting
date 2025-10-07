using Autoservice.Processing.Interfaces;
using Common.Processing.Editing;
using System;
using System.Linq;
namespace Autoservice.Processing.Editing
{
    public class MaintancesEditingController : EntityEditingController<MeintenanceModel>
    {
        new protected readonly IMaintancesEditor _editor;
        new protected readonly IMeintenanceEditingView _view;

        public MaintancesEditingController(IMaintancesEditor editor, IMeintenanceEditingView view)
            : base(editor, view)
        {
            _editor = editor;
            _view = view;
        }

        protected override void SetSelectionListsItems()
        {
            _view.UpdateTransportSelectionList(_editor.TransportSelectionItems.ToArray());
            _view.UpdateServiceSelectionList(_editor.ServiceSelectionItems.ToArray());
        }

   
    }
}