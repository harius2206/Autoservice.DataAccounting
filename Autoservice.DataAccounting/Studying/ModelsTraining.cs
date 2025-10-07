//using System;
//using Autoservice.UI.Models;
//using Autoservice.UI.Formatting.Simple;

//namespace Autoservice.DataAccounting.Studying
//{
//    internal static class ModelsTraining
//    {
//        internal static void Run()
//        {
//            Console.WriteLine(" === ModelsTraining ===");

//            StudySTOModel();
//            StudyTransportModel();
//        }
//        private static void StudySTOModel()
//        {
//            Console.WriteLine("\n --- StudySTOModel ---");

//            OwnerModel model1 = new OwnerModel
//            {
//                Name = "Hariuss",
//                Email = "fasd@gmail.com",
//                Address = "Соборна 21"
//            };

//            string indent = "      "; //відступ

//            Console.WriteLine(indent + "Name1: " + model1.Name);
//            Console.WriteLine(indent + "Name1: {0}", model1.Name);
//            Console.WriteLine($"{indent}Name1: {model1.Name}");

//            Console.WriteLine("model1:\n{0}", ModelsFormatting.ToDataString(model1));
//            Console.WriteLine("model1:\n{0}", model1.ToDataString());
//        }
//        private static void StudyTransportModel()
//        {
//            Console.WriteLine("\n --- StudyTransportModel ---");

//            TransportModel model2 = new TransportModel
//            {
//                Make = "Ford",
//                Model = "Focus",
//                Number = "AA 1234 AA",
//                Description = "Седан",
//                Owner = "Hariuss",
//                Parent = null
//            };
//            Console.WriteLine("model2:\n{0}", ModelsFormatting.ToDataString(model2));
//        }
//    }
//}