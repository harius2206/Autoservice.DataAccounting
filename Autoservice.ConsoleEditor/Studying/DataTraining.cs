using System;
using System.Linq;
using Autoservice.Data;
using Autoservice.Data.Formatting;
using Autoservice.Data.Testing;
using Common.Data.IO.Interfaces;
using Common.Interfaces.Extensions;

namespace Autoservice.ConsoleEditor.Studying
{
    internal class DataTraining
    {
        internal static void Run()
        {
            Console.WriteLine(" === DataTraining ===");
            // Закоментовано виклики інших дослідницьких методів
            // StudyDataSet();
            StudyIKeyable();
        }

        internal static void StudyDataSet()
        {
            Console.WriteLine(" --- StudyDataSet ---");

            DataSet dataSet = new DataSet();

            Console.WriteLine(new string('-', Console.BufferWidth - 1));

            dataSet.CreateTestingData();

            Console.WriteLine(dataSet.ToDataString("DataString"));

            Console.WriteLine("dataSet.Owners.First():\n" + dataSet.Owners.First());
            Console.WriteLine("dataSet.Transports.FirstOrDefault():\n" + dataSet.Transports.FirstOrDefault());

            Console.WriteLine(new string('=', Console.BufferWidth - 1));

            Console.WriteLine(dataSet.ToStatisticsString("StatisticsString"));
            Console.WriteLine("dataSet.IsEmpty():\t" + dataSet.IsEmpty());

            bool result1 = dataSet.CreateTestingData();
            Console.WriteLine("result1:\t" + result1);

            dataSet.Clear();

            Console.WriteLine(dataSet.ToStatisticsString("StatisticsString"));
            Console.WriteLine("dataSet.IsEmpty():\t" + dataSet.IsEmpty());

            bool result2 = dataSet.CreateTestingData();
            Console.WriteLine("result2:\t" + result2);
        }

        internal static void StudyIKeyable()
        {
            Console.WriteLine(" --- StudyIKeyable ---");

            IDataSet dataSet = new DataSet();

            Console.WriteLine(dataSet.Owners.ToKeyList("Owners"));
            dataSet.CreateTestingData();
            Console.WriteLine(dataSet.Owners.ToKeyList("Owners"));
            Console.WriteLine(dataSet.Owners.ToKeyLine("Owners"));
            Console.WriteLine(dataSet.Transports.ToKeyList("Transports"));

            Console.WriteLine(dataSet.ToKeyList("KeyList"));

            Console.WriteLine(new string('-', Console.BufferWidth - 1));

            Console.WriteLine("Ієрархії ключів:");
            foreach (var obj in dataSet.Transports)
            {
                Console.WriteLine("\t" + obj.ToKeysHierarchy());
            }
        }
    }
}