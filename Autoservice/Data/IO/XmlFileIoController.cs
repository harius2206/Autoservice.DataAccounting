using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using Autoservice.Entities;
using Common.Data.IO.Interfaces;
using Common.ConsoleIO;

namespace Autoservice.Data.IO
{
    public class XmlFileIoController : IFileIoController<IDataSet>
    {
        public string FileExtension => ".xml";

        public string FileTypeCaption => "XML File";

        public string Key => string.Format("{0} ({1})", FileTypeCaption, FileExtension);

        public void Save(IDataSet dataSet, string filePath)
        {
            //Console.WriteLine("Введіть дані для збереження:");
            //decimal? price = Inputting.InputNullableDecimal("Введіть ціну послуги:");
            //double? cost = Inputting.InputNullableDouble("Введіть вартість обслуговування:");
            //TimeSpan? duration = Inputting.InputNullableTimeSpan("Введіть тривалість послуги (hh:mm:ss):");

            //if (price.HasValue)
            //    Console.WriteLine($"Ціна послуги: {price.Value}");
            //if (cost.HasValue)
            //    Console.WriteLine($"Вартість обслуговування: {cost.Value}");
            //if (duration.HasValue)
            //    Console.WriteLine($"Тривалість послуги: {duration.Value}");

            filePath = Path.ChangeExtension(filePath, FileExtension);

            XmlWriterSettings settings = new XmlWriterSettings
            {
                Encoding = Encoding.Unicode,
                Indent = true
            };

            using (XmlWriter writer = XmlWriter.Create(filePath, settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("AutoserviceData");

                WriteData(dataSet, writer);

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }

        public bool Load(IDataSet dataSet, string filePath)
        {
            filePath = Path.ChangeExtension(filePath, FileExtension);

            if (!File.Exists(filePath))
                return false;

            XmlReaderSettings settings = new XmlReaderSettings
            {
                IgnoreWhitespace = true
            };

            using (XmlReader reader = XmlReader.Create(filePath, settings))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        ReadData(dataSet, reader);
                    }
                }
            }

            return true;
        }

        private void WriteOwners(IEnumerable<Owner> collection, XmlWriter writer)
        {
            writer.WriteStartElement("OwnersData");

            foreach (var obj in collection)
            {
                writer.WriteStartElement("Owner");
                writer.WriteElementString("Id", obj.Id.ToString());
                writer.WriteElementString("Name", obj.Name);
                writer.WriteElementString("Email", obj.Email);
                writer.WriteElementString("Address", obj.Address);
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
        }

        private void WriteServices(IEnumerable<Service> collection, XmlWriter writer)
        {
            writer.WriteStartElement("ServicesData");

            foreach (var obj in collection)
            {
                writer.WriteStartElement("Service");
                writer.WriteElementString("Id", obj.Id.ToString());
                writer.WriteElementString("Name", obj.Name);
                writer.WriteElementString("Price", obj.Price.ToString());
                writer.WriteElementString("Duration", obj.Duration.ToString());
                writer.WriteElementString("WarrantyPeriod", obj.WarrantyPeriod.ToString());
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
        }

        private void WriteTransports(IEnumerable<Transport> collection, XmlWriter writer)
        {
            writer.WriteStartElement("TransportsData");

            foreach (var obj in collection)
            {
                writer.WriteStartElement("Transport");
                writer.WriteElementString("Id", obj.Id.ToString());
                writer.WriteElementString("Make", obj.Make);
                writer.WriteElementString("Model", obj.Model);
                writer.WriteElementString("Number", obj.Number);
                writer.WriteElementString("Description", obj.Description);
                writer.WriteElementString("OwnerId", obj.Owner?.Id.ToString() ?? "0");
                writer.WriteElementString("ParentId", obj.Parent?.Id.ToString() ?? "0");
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
        }

        private void WriteMaintenances(IEnumerable<Maintenance> collection, XmlWriter writer)
        {
            writer.WriteStartElement("MaintenancesData");

            foreach (var obj in collection)
            {
                writer.WriteStartElement("Maintenance");
                writer.WriteElementString("Id", obj.Id.ToString());
                writer.WriteElementString("TransportId", obj.Transport?.Id.ToString() ?? "0");
                writer.WriteElementString("ServiceId", obj.Service?.Id.ToString() ?? "0");
                writer.WriteElementString("Date", obj.Date.HasValue? obj.Date.Value.ToString("dd.MM.yyyy") : string.Empty);
                writer.WriteElementString("Cost", obj.Cost.ToString());
                writer.WriteElementString("Note", obj.Note);
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
        }

        protected virtual void WriteData(IDataSet dataSet, XmlWriter writer)
        {
            WriteOwners(dataSet.Owners, writer);
            WriteServices(dataSet.Services, writer);
            WriteTransports(dataSet.Transports, writer);
            WriteMaintenances(dataSet.Maintenances, writer);
        }

        private void ReadOwner(XmlReader reader, ICollection<Owner> collection)
        {
            Owner obj = new Owner();
            reader.ReadStartElement("Owner");
            obj.Id = reader.ReadElementContentAsInt();
            obj.Name = reader.ReadElementContentAsString();
            obj.Email = reader.ReadElementContentAsString();
            obj.Address = reader.ReadElementContentAsString();
            collection.Add(obj);
            reader.ReadEndElement();
        }

        private void ReadService(XmlReader reader, ICollection<Service> collection)
        {
            Service obj = new Service();
            reader.ReadStartElement("Service");
            obj.Id = reader.ReadElementContentAsInt();
            obj.Name = reader.ReadElementContentAsString();
            obj.Price = reader.ReadElementContentAsDecimal();
            obj.Duration = TimeSpan.Parse(reader.ReadElementContentAsString());
            obj.WarrantyPeriod = TimeSpan.Parse(reader.ReadElementContentAsString());
            collection.Add(obj);
            reader.ReadEndElement();
        }

        private void ReadTransport(XmlReader reader, ICollection<Transport> collection, ICollection<Owner> owners)
        {
            Transport obj = new Transport();
            reader.ReadStartElement("Transport");
            obj.Id = reader.ReadElementContentAsInt();
            obj.Make = reader.ReadElementContentAsString();
            obj.Model = reader.ReadElementContentAsString();
            obj.Number = reader.ReadElementContentAsString();
            obj.Description = reader.ReadElementContentAsString();
            int ownerId = reader.ReadElementContentAsInt();
            obj.Owner = owners.FirstOrDefault(o => o.Id == ownerId);
            int parentId = reader.ReadElementContentAsInt();
            obj.Parent = collection.FirstOrDefault(t => t.Id == parentId);
            collection.Add(obj);
            reader.ReadEndElement();
        }

        private void ReadMaintenance(XmlReader reader, ICollection<Maintenance> collection, ICollection<Transport> transports, ICollection<Service> services)
        {
            Maintenance obj = new Maintenance();
            reader.ReadStartElement("Maintenance");
            obj.Id = reader.ReadElementContentAsInt();
            int transportId = reader.ReadElementContentAsInt();
            obj.Transport = transports.FirstOrDefault(t => t.Id == transportId);
            int serviceId = reader.ReadElementContentAsInt();
            obj.Service = services.FirstOrDefault(s => s.Id == serviceId);
            obj.Date = DateTime.Parse(reader.ReadElementContentAsString());
            obj.Cost = reader.ReadElementContentAsDecimal();
            obj.Note = reader.ReadElementContentAsString();
            collection.Add(obj);
            reader.ReadEndElement();
        }

        protected void ReadData(IDataSet dataSet, XmlReader reader)
        {
            switch (reader.Name)
            {
                case "Owner":
                    ReadOwner(reader, dataSet.Owners);
                    break;
                case "Service":
                    ReadService(reader, dataSet.Services);
                    break;
                case "Transport":
                    ReadTransport(reader, dataSet.Transports, dataSet.Owners);
                    break;
                case "Maintenance":
                    ReadMaintenance(reader, dataSet.Maintenances, dataSet.Transports, dataSet.Services);
                    break;
            }
        }
    }
}