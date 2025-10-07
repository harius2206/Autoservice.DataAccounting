using System;
using Autoservice.UI.Models;
using Autoservice.UI.Formatting.Simple;

namespace Autoservice.DataAccounting.Studying
{
    internal static class ModelsTraining
    {
        internal static void Run()
        {
            Console.WriteLine(" === ModelsTraining ===");

            StudySTOModel();
            StudyTransportModel();
        }

        private static void StudySTOModel()
        {
            Console.WriteLine("\n --- StudySTOModel ---");

            STO model1 = new STO
            {
                Name = "Hariuss",
                StationID = "STO-001",
                Adress = "Замостянська 24",
                MaxCars = 100,
                Area = 120,
                WorkersCount = 15,
                Year = 2007
            };

            string indent = "      "; //відступ

            Console.WriteLine(indent + "Name1: " + model1.Name);
            Console.WriteLine(indent + "Name1: {0}", model1.Name);
            Console.WriteLine($"{indent}Name1: {model1.Name}");

            Console.WriteLine("model1:\n{0}", ModelsFormatting.ToDataString(model1));
            Console.WriteLine("model1:\n{0}", model1.ToDataString());
        }

        private static void StudyTransportModel()
        {
            Console.WriteLine("\n --- StudyTransportModel ---");

            Transport model2 = new Transport
            {
                Mark = "Ford",
                Model = "Focus",
                Numb = "AA 1234 AA",
                BType = "Sedan",
                Mass = 1500
            };

            Console.WriteLine("model2:\n{0}", ModelsFormatting.ToDataString(model2));
        }
    }




}