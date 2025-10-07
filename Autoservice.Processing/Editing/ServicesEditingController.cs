using Autoservice.Processing.Interfaces;
using Common.Processing.Editing;

namespace Autoservice.Processing.Editing
{
    public class ServicesEditingController : EntityEditingController<ServiceModel>
    {
        new protected readonly IServicesEditor _editor;
        new protected readonly IServicesEditingView _view;

        public ServicesEditingController(IServicesEditor editor, IServicesEditingView view)
            : base((Common.Processing.Interfaces.IEntityEditor<ServiceModel>)editor,
                   (Common.Processing.Interfaces.IEditingView<ServiceModel>)view)
        {
            _editor = editor;
            _view = view;
        }

        protected override void SetSelectionListsItems()
        {
        }
    }
}