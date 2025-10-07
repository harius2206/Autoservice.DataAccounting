using System.Collections.Generic;
using Common.Processing.Interfaces;

namespace Autoservice.Processing.Interfaces
{
    public interface ITransportsEditor : IEntityEditor<TransportModel>
    {
        IEnumerable<string> ParentSelectionItems { get; }
        IEnumerable<string> VlasnukSelectionItems { get; }

    }
}