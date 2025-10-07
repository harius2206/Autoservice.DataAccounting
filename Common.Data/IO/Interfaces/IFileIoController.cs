using System;

namespace Common.Data.IO.Interfaces
{
    public interface IFileIoController<TData> : IFileTypeInformer where TData : IBaseDataSet
    {
        void Save(TData dataSet, string filePath);
        bool Load(TData dataSet, string filePath);
    }
}