using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Common.Data.IO.Interfaces;
using Common.Data.IO;

namespace Autoservice.Data.IO
{
    public class BinaryFileIoController : BaseFileTypeInformer, IFileIoController<IDataSet>
    {
        public BinaryFileIoController() : base("Двійкові файли", ".bin") { }

        public void Save(IDataSet dataSet, string filePath)
        {
            filePath = Path.ChangeExtension(filePath, FileExtension);
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fStream = File.OpenWrite(filePath))
            {
                formatter.Serialize(fStream, dataSet);
            }
        }

        public bool Load(IDataSet dataSet, string filePath)
        {
            filePath = Path.ChangeExtension(filePath, FileExtension);

            if (!File.Exists(filePath))
                return false;

            FileStream fStream = null;

            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                fStream = File.OpenRead(filePath);

                IDataSet newDataSet = (IDataSet)formatter.Deserialize(fStream);

                if (newDataSet == null)
                    return false;

                newDataSet.CopyTo(dataSet);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка під час завантаження даних: {ex.Message}");
                return false;
            }
            finally
            {
                if (fStream != null)
                {
                    fStream.Close();
                }
            }
        }
    }
}