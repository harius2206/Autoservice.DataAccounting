//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Text;
//using Autoservice.UI.Models;
//using Common.IO;

//namespace Autoservice.UI.Data.IO
//{
//    public class DataFileIoController
//    {
//        public static Encoding Encoding = Encoding.Unicode;
//        public static string Indent = "  ";

//        public bool Load(ModelsListsSet listsSet, string filePath)
//        {
//            if (!File.Exists(filePath))
//                return false;

//            var ownerModels = new List<OwnerModel>();
//            var serviceModels = new List<ServiceModel>();
//            var transportModels = new List<TransportModel>();
//            var meintenanceModels = new List<MeintenanceModel>();

//            // Перший прохід: зчитуємо всі моделі, крім Meintenance
//            using (StreamReader sr = new StreamReader(filePath, Encoding.Unicode))
//            {
//                while (sr.Peek() >= 0)
//                {
//                    string entityName = TextIo.GetCaption(sr.ReadLine());
//                    switch (entityName)
//                    {
//                        case "Owner":
//                            ownerModels.Add(CreateOwnerModel(sr));
//                            break;
//                        case "Service":
//                            serviceModels.Add(CreateServiceModel(sr));
//                            break;
//                        case "Transport":
//                            transportModels.Add(CreateTransportModel(sr));
//                            break;
//                        case "Meintenance":
//                            // Пропускаємо, обробимо на другому проході
//                            for (int i = 0; i < 6; i++) sr.ReadLine();
//                            break;
//                    }
//                }
//            }

//            // Другий прохід: зчитуємо тільки Meintenance, вже маючи списки транспортів і сервісів
//            using (StreamReader sr = new StreamReader(filePath, Encoding.Unicode))
//            {
//                while (sr.Peek() >= 0)
//                {
//                    string entityName = TextIo.GetCaption(sr.ReadLine());
//                    switch (entityName)
//                    {
//                        case "Meintenance":
//                            meintenanceModels.Add(CreateMeintenanceModel(sr, transportModels, serviceModels));
//                            break;
//                        default:
//                            int skip = entityName == "Owner" ? 4 :
//                                       entityName == "Service" ? 5 :
//                                       entityName == "Transport" ? 7 : 0;
//                            for (int i = 0; i < skip; i++) sr.ReadLine();
//                            break;
//                    }
//                }
//            }

//            listsSet.OwnerModels.AddRange(ownerModels);
//            listsSet.ServiceModels.AddRange(serviceModels);
//            listsSet.TransportModels.AddRange(transportModels);
//            listsSet.MeintenanceModels.AddRange(meintenanceModels);

//            return true;
//        }

//        private OwnerModel CreateOwnerModel(StreamReader sr)
//        {
//            OwnerModel model = new OwnerModel();
//            model.Id = int.Parse(TextIo.GetValue(sr.ReadLine()));
//            model.Name = TextIo.GetValue(sr.ReadLine());
//            model.Email = TextIo.GetValue(sr.ReadLine());
//            model.Address = TextIo.GetValue(sr.ReadLine());
//            return model;
//        }

//        private ServiceModel CreateServiceModel(StreamReader sr)
//        {
//            ServiceModel model = new ServiceModel();
//            model.Id = int.Parse(TextIo.GetValue(sr.ReadLine()));
//            model.Name = TextIo.GetValue(sr.ReadLine());
//            model.Price = decimal.Parse(TextIo.GetValue(sr.ReadLine()));
//            model.Duration = int.Parse(TextIo.GetValue(sr.ReadLine()));
//            model.WarrantyPeriod = int.Parse(TextIo.GetValue(sr.ReadLine()));
//            return model;
//        }

//        private TransportModel CreateTransportModel(StreamReader sr)
//        {
//            TransportModel model = new TransportModel();
//            model.Id = int.Parse(TextIo.GetValue(sr.ReadLine()));
//            model.Make = TextIo.GetValue(sr.ReadLine());
//            model.Model = TextIo.GetValue(sr.ReadLine());
//            model.Number = TextIo.GetValue(sr.ReadLine());
//            model.Description = TextIo.GetValue(sr.ReadLine());
//            model.Owner = TextIo.GetValue(sr.ReadLine());
//            model.Parent = TextIo.GetValue(sr.ReadLine());
//            return model;
//        }

//        public MeintenanceModel CreateMeintenanceModel(
//             StreamReader sr,
//             List<TransportModel> transports,
//             List<ServiceModel> services)
//        {
//            MeintenanceModel model = new MeintenanceModel();
//            model.Id = int.Parse(TextIo.GetValue(sr.ReadLine()));
//            string transportKey = TextIo.GetValue(sr.ReadLine());
//            model.Transport = transports.Find(t => t.Key == transportKey || t.Id.ToString() == transportKey);
//            string serviceName = TextIo.GetValue(sr.ReadLine());
//            model.Service = services.Find(s => s.Name == serviceName || s.Id.ToString() == serviceName);
//            string dateStr = TextIo.GetValue(sr.ReadLine());
//            model.Date = string.IsNullOrEmpty(dateStr) ? (DateTime?)null : DateTime.Parse(dateStr);
//            string costStr = TextIo.GetValue(sr.ReadLine());
//            model.Cost = string.IsNullOrEmpty(costStr) ? (decimal?)null : decimal.Parse(costStr);
//            model.Note = TextIo.GetValue(sr.ReadLine());
//            return model;
//        }

//        public static void Save(ModelsListsSet listsSet, string filePath)
//        {
//            StringBuilder sb = new StringBuilder();
//            sb.Append(CreateDataString(listsSet.OwnerModels));
//            sb.Append(CreateDataString(listsSet.ServiceModels));
//            sb.Append(CreateDataString(listsSet.TransportModels));
//            sb.Append(CreateDataString(listsSet.MeintenanceModels));

//            File.WriteAllText(filePath, sb.ToString(), Encoding);
//        }

//        private static string CreateDataString<T>(List<T> models)
//        {
//            StringBuilder sb = new StringBuilder();
//            foreach (var model in models)
//            {
//                sb.Append(CreateObjectString(model));
//            }
//            return sb.ToString();
//        }

//        private static string CreateObjectString(object model)
//        {
//            if (model is OwnerModel owner)
//            {
//                return string.Format(
//                    "Owner:\n"
//                    + "{0}Id: {1}\n"
//                    + "{0}Name: {2}\n"
//                    + "{0}Email: {3}\n"
//                    + "{0}Address: {4}\n",
//                    Indent,
//                    owner.Id,
//                    owner.Name,
//                    owner.Email,
//                    owner.Address
//                );
//            }
//            else if (model is ServiceModel service)
//            {
//                return string.Format(
//                    "Service:\n"
//                    + "{0}Id: {1}\n"
//                    + "{0}Name: {2}\n"
//                    + "{0}Price: {3}\n"
//                    + "{0}Duration: {4}\n"
//                    + "{0}WarrantyPeriod: {5}\n",
//                    Indent,
//                    service.Id,
//                    service.Name,
//                    service.Price,
//                    service.Duration,
//                    service.WarrantyPeriod
//                );
//            }
//            else if (model is TransportModel transport)
//            {
//                return string.Format(
//                    "Transport:\n"
//                    + "{0}Id: {1}\n"
//                    + "{0}Make: {2}\n"
//                    + "{0}Model: {3}\n"
//                    + "{0}Number: {4}\n"
//                    + "{0}Description: {5}\n"
//                    + "{0}Owner: {6}\n"
//                    + "{0}Parent: {7}\n",
//                    Indent,
//                    transport.Id,
//                    transport.Make,
//                    transport.Model,
//                    transport.Number,
//                    transport.Description,
//                    transport.Owner,
//                    transport.Parent
//                );
//            }
//            else if (model is MeintenanceModel meintenance)
//            {
//                return string.Format(
//                    "Meintenance:\n"
//                    + "{0}Id: {1}\n"
//                    + "{0}Transport: {2}\n"
//                    + "{0}Service: {3}\n"
//                    + "{0}Date: {4}\n"
//                    + "{0}Cost: {5}\n"
//                    + "{0}Note: {6}\n",
//                    Indent,
//                    meintenance.Id,
//                    meintenance.Transport?.Key ?? "",
//                    meintenance.Service?.Name ?? "",
//                    meintenance.Date?.ToString("yyyy-MM-dd") ?? "",
//                    meintenance.Cost,
//                    meintenance.Note
//                );
//            }
//            return string.Empty;
//        }
//    }
//}