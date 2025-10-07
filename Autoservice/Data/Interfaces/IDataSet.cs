using Autoservice.Entities;
using System.Collections.Generic;

namespace Common.Data.IO.Interfaces
{
    public interface IDataSet : IBaseDataSet
    {
        ICollection<Owner> Owners { get; }
        ICollection<Transport> Transports { get; }
        ICollection<Service> Services { get; }
        ICollection<Maintenance> Maintenances { get; }


        void CopyTo(IDataSet dataSet);
    }
}