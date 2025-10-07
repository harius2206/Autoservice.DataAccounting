//using System;
//using ArchivalCase.UI.Tables;
//using Autoservice.UI.Data;
//using Autoservice.UI.Data.Testing;
//using Autoservice.UI.Settings.Tables;
//using Common.Formatting.Tables;

//namespace Autoservice.DataAccounting.Studying
//{
//    internal class TableFormattingTraining
//    {
//        internal static void Run()
//        {
//            Console.WriteLine(" === TableFormattingTraining ===");

//            //StudySimpleDataTableFormatting();
//            //StudyBorderedDataTableFormatting();
//            StudyColumnVisibility();
//            //StudyBorderStyles();
//        }

//        private static void StudySimpleDataTableFormatting()
//        {
//            Console.WriteLine(" --- StudySimpleDataTableFormatting ---");

//            ModelsListsSet listsSet = new ModelsListsSet();
//            ModelsCreation.CreateTestingModels(listsSet);

//            Console.WriteLine(SimpleTablesFormatting.ToTable(listsSet.OwnerModels));
//            Console.WriteLine(SimpleTablesFormatting.ToTable(listsSet.ServiceModels));
//        }

//        private static void StudyBorderedDataTableFormatting()
//        {
//            Console.WriteLine(" --- StudyBorderedDataTableFormatting ---");

//            ModelsListsSet listsSet = new ModelsListsSet();
//            ModelsCreation.CreateTestingModels(listsSet);

//            Console.Write(listsSet.OwnerModels.ToTable());
//            Console.Write(listsSet.OwnerModels.ToTable(BorderStyle.InnerHorizontalSingle));
//        }

//        private static void StudyBorderStyles()
//        {
//            Console.WriteLine(" --- StudyBorderStyles ---");

//            ModelsListsSet listsSet = new ModelsListsSet();
//            ModelsCreation.CreateTestingModels(listsSet);

//            foreach (BorderStyle el in BorderStylesInfo.Values)
//            {
//                Console.WriteLine("\n {0} - {1}", el, el.ToCaption());
//                Console.Write(OwnerTablesFormatting.ToTable(listsSet.OwnerModels, el));
//            }
//        }

//        private static void StudyColumnVisibility()
//        {
//            Console.WriteLine(" --- StudyColumnVisibility ---");

//            ModelsListsSet listsSet = new ModelsListsSet();
//            ModelsCreation.CreateTestingModels(listsSet);

//            Console.Write(listsSet.OwnerModels.ToTable());

//            bool[] visibles = new bool[OwnerTableSettings.Current.ColumnsCount];
//            visibles[(int)OwnerTableColumn.Id] = true;
//            visibles[(int)OwnerTableColumn.Name] = true;
//            visibles[(int)OwnerTableColumn.Email] = true;
//            visibles[(int)OwnerTableColumn.Address] = true;

//            Console.Write(listsSet.OwnerModels.ToTable(visibles));

//            Console.Write(listsSet.OwnerModels.ToTable(0x0F));
//        }
//    }
//}