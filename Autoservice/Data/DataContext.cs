using Autoservice.Data.Formatting;
using Autoservice.Data.Interfaces;
using Autoservice.Data.Testing;
using Autoservice.Entities;
using Common.Data;
using Common.Data.IO.Interfaces;
using System.Collections.Generic;

namespace Autoservice.Data
{
    public class DataContext : BaseDataContext<IDataSet>, IDataContext
    {
        public ICollection<Owner> Owners => DataSet.Owners;
        public ICollection<Transport> Transports => DataSet.Transports;
        public ICollection<Service> Services => DataSet.Services;
        public ICollection<Maintenance> Maintenances => DataSet.Maintenances;

        public DataContext(IFileIoController<IDataSet> fileIoController,
            IDataSet dataSet, string directoryName, string fileName)
            : base(fileIoController, dataSet, directoryName, fileName)
        {
        }

        public DataContext(IFileIoController<IDataSet> fileIoController)
            : this(fileIoController, new DataSet(), "", "Autoservice")
        {
        }

        public override string ToString()
        {
            return DataSet.ToDataString();
        }

        public bool CreateTestingData()
        {
            if (DataSet.CreateTestingData())
            {
                OnDataChanged();
                return true;
            }
            return false;
        }

        public void CopyTo(IDataSet dataSet)
        {
            DataSet.CopyTo(dataSet);
        }
    }
}