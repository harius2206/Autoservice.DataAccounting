using Common.Processing.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoservice.Processing.Interfaces
{
    public interface IOwnersEditingView : IEditingView<OwnerModel>
    {
        void UpdateParentSelectionList(string[] names);

    }
}
