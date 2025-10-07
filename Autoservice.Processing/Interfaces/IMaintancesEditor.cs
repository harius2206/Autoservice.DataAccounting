using Common.Processing.Interfaces;
using System.Collections.Generic;

namespace Autoservice.Processing.Interfaces
{
    public interface IMaintancesEditor : IEntityEditor<MeintenanceModel>
    {
        IEnumerable<string> TransportSelectionItems { get; }
        IEnumerable<string> ServiceSelectionItems { get; }
    }
}