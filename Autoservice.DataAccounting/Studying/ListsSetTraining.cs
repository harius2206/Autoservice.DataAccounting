//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Autoservice.UI.Data;
//using Autoservice.UI.Formatting;
//using Autoservice.UI.Data.Testing;

//namespace Autoservice.DataAccounting.Studying
//{
//    internal class ListsSetTraining
//    {
//        internal static void Run()
//        {
//            Console.WriteLine("\n --- ListsSetTraining ---");
//            // StudyStatisticsString();
//            StudyToDataString();
//        }

//        private static void StudyStatisticsString()
//        {
//            Console.WriteLine("\n --- StudyStatisticsString ---");

//            ModelsListsSet listsSet = new ModelsListsSet();

//            ModelsCreation.CreateTestingModels(listsSet);

//            Console.WriteLine(DataFormatting.ToStatisticsString(listsSet));
//        }

//        private static void StudyToDataString()
//        {
//            Console.WriteLine("\n --- StudyToDataString ---");

//            ModelsListsSet listsSet = new ModelsListsSet();

//            Console.WriteLine(DataFormatting.ToDataString(listsSet));

//            ModelsCreation.CreateTestingModels(listsSet);

//            Console.WriteLine(DataFormatting.ToDataString(listsSet));
//        }
//    }
//}