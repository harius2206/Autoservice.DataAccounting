using System;
using System.Collections.Generic;
using Autoservice.Entities;
using Common.Data.IO.Interfaces;

namespace Autoservice.Data
{
    [Serializable] 
    public class DataSet : IDataSet
    {
        public ICollection<Owner> Owners { get; } = new List<Owner>();
        public ICollection<Transport> Transports { get; } = new List<Transport>();
        public ICollection<Service> Services { get; } = new List<Service>();
        public ICollection<Maintenance> Maintenances { get; } = new List<Maintenance>();

        public void Clear()
        {
            Owners.Clear();
            Transports.Clear();
            Services.Clear();
            Maintenances.Clear();
        }

        public void CopyTo(IDataSet dataSet)
        {
            foreach (var owner in Owners) dataSet.Owners.Add(owner);
            foreach (var transport in Transports) dataSet.Transports.Add(transport);
            foreach (var service in Services) dataSet.Services.Add(service);
            foreach (var maintenance in Maintenances) dataSet.Maintenances.Add(maintenance);
        }

        public bool IsEmpty()
        {
            return Owners.Count == 0 && Transports.Count == 0 && Services.Count == 0 && Maintenances.Count == 0;
        }
    }
}