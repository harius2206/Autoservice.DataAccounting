using Common.Processing.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoservice.Processing.Interfaces
{
    public interface IMeintenanceEditingView : IEditingView<MeintenanceModel>
    {
        void UpdateTransportSelectionList(string[] items);
        void UpdateServiceSelectionList(string[] items);
    }
}
