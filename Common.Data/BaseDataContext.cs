using System;
using System.IO;
using Common.Data.Interfaces;
using Common.Data.IO.Interfaces;
using Common.IO;

namespace Common.Data
{
    public class BaseDataContext<TData> : IBaseDataContext, IDataChangeable
        where TData : IBaseDataSet
    {
        private string _directoryName = "";

        public string DirectoryName
        {
            get { return _directoryName; }
            set
            {
                _directoryName = value;
                Saving.CheckAndCreateDirectory(ref _directoryName); 
            }
        }

        public string FileName { get; set; }

        protected TData DataSet { get; }

        private IFileIoController<TData> _fileIoController;

        public IFileIoController<TData> FileIoController
        {
            get { return _fileIoController; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value));
                }
                _fileIoController = value;
            }
        }

        public BaseDataContext(IFileIoController<TData> fileIoController,
            TData dataSet, string directoryName, string fileName)
        {
            if (dataSet == null)
            {
                throw new ArgumentNullException(nameof(dataSet));
            }
            DataSet = dataSet;
            FileIoController = fileIoController;
            DirectoryName = directoryName;
            FileName = fileName;
        }

        public event EventHandler<EventArgs> DataChanged;

        protected void OnDataChanged() => DataChanged?.Invoke(this, EventArgs.Empty);

        public void Clear()
        {
            DataSet.Clear();
            OnDataChanged();
        }

        public bool IsEmpty()
        {
            return DataSet.IsEmpty();
        }

        public void Save(string filePath)
        {
            Saving.CheckAndPrepareFilePath(ref filePath); 
            FileIoController.Save(DataSet, filePath);
        }

        public void Save()
        {
            Save(FilePath); 
        }

        public bool Load(string filePath)
        {
            bool result = FileIoController.Load(DataSet, filePath);
            if (result)
            {
                OnDataChanged();
            }
            return result;
        }

        public bool Load()
        {
            return Load(FilePath); 
        }

        public string FilePath
        {
            get
            {
                return Path.Combine(DirectoryName, FileName + FileIoController.FileExtension);
            }
        }
    }
}