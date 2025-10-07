//using System;
//using Autoservice.UI.Models;

//namespace Autoservice.UI.Data.Testing
//{
//    public static class ModelsCreation
//    {
//        public static OwnerModel[] CreateOwnerModelsArray()
//        {
//            OwnerModel[] modelsArray = {
//                new OwnerModel() {
//                    Id = 1,
//                    Name = "Hariuss",
//                    Email = "fasd@gmail.com",
//                    Address = "Соборна 21"
//                },
//                new OwnerModel() {
//                    Id = 2,
//                    Name = "John Doe",
//                    Email = "john.doe@example.com",
//                    Address = "Main Street 1"
//                },
//                new OwnerModel() {
//                    Id = 3,
//                    Name = "Jane Smith",
//                    Email = "jane.smith@example.com",
//                    Address = "Second Avenue 2"
//                }
//            };
//            return modelsArray;
//        }

//        public static TransportModel[] CreateTransportModelsArray()
//        {
//            TransportModel[] modelsArray = {
//                new TransportModel() {
//                    Id = 1,
//                    Make = "Ford",
//                    Model = "Focus",
//                    Number = "AA 1234 AA",
//                    Description = "Седан",
//                    Owner = "Hariuss",
//                    Parent = null
//                },
//                new TransportModel() {
//                    Id = 2,
//                    Make = "Toyota",
//                    Model = "Camry",
//                    Number = "BB 5678 BB",
//                    Description = "Седан",
//                    Owner = "John Doe",
//                    Parent = null
//                },
//                new TransportModel() {
//                    Id = 3,
//                    Make = "Honda",
//                    Model = "Civic",
//                    Number = "CC 9101 CC",
//                    Description = "Хетчбек",
//                    Owner = "Jane Smith",
//                    Parent = null
//                }
//            };
//            return modelsArray;
//        }

//        public static ServiceModel[] CreateServiceModelsArray()
//        {
//            ServiceModel[] modelsArray = {
//                new ServiceModel() {
//                    Id = 1,
//                    Name = "Заміна масла",
//                    Price = 500,
//                    Duration = 30,
//                    WarrantyPeriod = 6
//                },
//                new ServiceModel() {
//                    Id = 2,
//                    Name = "Ремонт двигуна",
//                    Price = 15000,
//                    Duration = 240,
//                    WarrantyPeriod = 12
//                },
//                new ServiceModel() {
//                    Id = 3,
//                    Name = "Балансування коліс",
//                    Price = 300,
//                    Duration = 45,
//                    WarrantyPeriod = 3
//                }
//            };
//            return modelsArray;
//        }

//        public static bool CreateTestingModels(this ModelsListsSet listsSet)
//        {
//            if (listsSet == null || !listsSet.IsEmpty())
//            {
//                return false;
//            }
//            listsSet.OwnerModels.AddRange(CreateOwnerModelsArray());
//            listsSet.TransportModels.AddRange(CreateTransportModelsArray());
//            listsSet.ServiceModels.AddRange(CreateServiceModelsArray());
//            return true;
//        }
//    }
//}