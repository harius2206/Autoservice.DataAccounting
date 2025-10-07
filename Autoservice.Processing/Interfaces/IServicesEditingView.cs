using Common.Processing.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoservice.Processing.Interfaces
{
    public interface IServicesEditingView : IEditingView<ServiceModel>
    {
        void UpdateParentSelectionList(string[] names);

    }
}
