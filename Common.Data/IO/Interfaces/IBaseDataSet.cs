using System;

namespace Common.Data.IO.Interfaces
{
    public interface IBaseDataSet
    {
        void Clear();
        bool IsEmpty();
    }
}