using Common.Processing.Interfaces;

namespace Autoservice.Processing.Interfaces
{
    public interface ITransportsEditingView : IEditingView<TransportModel>
    {
        void UpdateParentSelectionList(string[] names);
        void UpdateVlasnukSelectionList(string[] keys);
        //void UpdateVlasnukSelectionList(object value);
    }
}