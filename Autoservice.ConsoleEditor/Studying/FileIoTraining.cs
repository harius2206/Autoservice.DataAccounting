using System;
using Autoservice.Data.IO;
using Autoservice.Data.Testing;
using Autoservice.Data;
using Common.Data.IO.Interfaces;
using Common.ConsoleIO;
using Common.Data.IO;
using Common.Interfaces;
using Autoservice.Data.Formatting;
using Common.Interfaces.Extensions;

namespace Autoservice.ConsoleEditor.Studying
{
    internal static class FileIoTraining
    {
        internal static void Run()
        {
            Console.WriteLine(" === FileIoTraining ===");
            StudyDataContextIo();
            //StudyXmlFileIo();
            // StudyBinaryFileIo();
            //  StudyFileTypeSelection();
        }
        private static void StudyDataContextIo()
        {
            Console.WriteLine(" --- StudyDataContextIo ---");

            IFileIoController<IDataSet> fileIoController = new BinaryFileIoController();
            DataContext dataContext = new DataContext(fileIoController);
            Console.WriteLine("dataContext:\n" + dataContext);

            Console.WriteLine(new string('-', Console.BufferWidth - 1));

            dataContext.DataChanged += DataContext_DataChanged;
            Console.WriteLine("dataContext.IsEmpty():\t" + dataContext.IsEmpty());
            dataContext.CreateTestingData();
            Console.WriteLine("dataContext.IsEmpty():\t" + dataContext.IsEmpty());

            Console.WriteLine(dataContext.ToStatisticsString("StatisticsString"));
            DataContext dataContext2 = new DataContext(fileIoController);
            Console.WriteLine("dataContext2.IsEmpty():\t" + dataContext2.IsEmpty());
            dataContext.CopyTo(dataContext2);
            Console.WriteLine("dataContext2.IsEmpty():\t" + dataContext2.IsEmpty());
            dataContext.Clear();
            Console.WriteLine("dataContext.IsEmpty():\t" + dataContext.IsEmpty());
            Console.WriteLine("dataContext2:\n" + dataContext2);

            Console.WriteLine(new string('=', Console.BufferWidth - 1));

            string directoryName = @"..\..\files";
            dataContext2.DirectoryName = directoryName;
            dataContext2.Save();
            dataContext.DirectoryName = directoryName;
            dataContext.Load();
            Console.WriteLine("dataContext.IsEmpty():\t" + dataContext.IsEmpty());
            Console.WriteLine("dataContext:\n" + dataContext);
        }

        private static void DataContext_DataChanged(object sender, EventArgs e)
        {
            Console.WriteLine("DataContext_DataChanged");
        }


        private static void DataContext_DataChanged_Handler(object sender, EventArgs e)
        {
            Console.WriteLine("DataContext_DataChanged");
        }

      
        private static void StudyXmlFileIo()
        {
            Console.WriteLine(" --- StudyXmlFileIo ---");

            XmlFileIoController xmlController = new XmlFileIoController();

            IDataSet dataSet = new DataSet();
            dataSet.CreateTestingData();
            Console.WriteLine(dataSet.ToDataString("dataSet"));

            string fileName = "AutoServiceXml";
            xmlController.Save(dataSet, fileName);

            Console.WriteLine(new string('-', Console.BufferWidth - 1));

            dataSet.Clear();
            Console.WriteLine(dataSet.ToDataString("dataSet"));
            xmlController.Load(dataSet, fileName);
            Console.WriteLine(dataSet.ToDataString("dataSet"));
        }

        private static void StudyBinaryFileIo()
        {
            Console.WriteLine(" --- StudyBinaryFileIo ---");

            BinaryFileIoController binaryController = new BinaryFileIoController();

            IDataSet dataSet = new DataSet();
            dataSet.CreateTestingData();
            Console.WriteLine(dataSet.ToDataString("dataSet"));

            string fileName = "AutoServiceBinary";
            binaryController.Save(dataSet, fileName);

            Console.WriteLine(new string('-', Console.BufferWidth - 1));

            dataSet.Clear();
            Console.WriteLine(dataSet.ToDataString("dataSet"));
            binaryController.Load(dataSet, fileName);
            Console.WriteLine(dataSet.ToDataString("dataSet"));
        }

        private static void StudyFileTypeSelection()
        {
            Console.WriteLine(" --- StudyFileTypeSelection ---");

            BinaryFileIoController binaryController = new BinaryFileIoController();
            XmlFileIoController xmlController = new XmlFileIoController();

            IFileTypeInformer[] fileTypeInformers = new IFileTypeInformer[]
            {
                binaryController,
                xmlController
            };

            Console.WriteLine(fileTypeInformers.ToKeyList("fileTypeInformers"));

            Func<IKeyable[], string, IKeyable> keyableSelector =
                SelectionMethods.SelectKeyable;

            var fileTypeSelector = new FileTypeSelector(fileTypeInformers, keyableSelector);

            fileTypeSelector.Select();
            IFileTypeInformer selectedInformer = fileTypeSelector.CurrentInformer;
            Console.WriteLine("selectedInformer.Key: " + selectedInformer.Key);

            IFileIoController<IDataSet> fileIoController =
                selectedInformer as IFileIoController<IDataSet>;

            IDataSet dataSet = new DataSet();
            dataSet.CreateTestingData();

            Console.WriteLine(dataSet.ToDataString("dataSet"));

            string fileName = "AutoService";
            fileIoController.Save(dataSet, fileName);

            Console.WriteLine(new string('-', Console.BufferWidth - 1));

            dataSet.Clear();
            Console.WriteLine(dataSet.ToDataString("dataSet"));
            fileIoController.Load(dataSet, fileName);
            Console.WriteLine(dataSet.ToDataString("dataSet"));
        }

        private class ConcreteFileTypeSelector : FileTypeSelector
        {
            public ConcreteFileTypeSelector(IFileTypeInformer[] informers, Func<IKeyable[], string, IKeyable> selector)
                : base(informers, selector)
            {
            }
        }
    }
}