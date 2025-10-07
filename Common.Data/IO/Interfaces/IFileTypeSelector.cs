using System;

namespace Common.Data.IO.Interfaces
{
    public interface IFileTypeSelector
    {
        IFileTypeInformer CurrentInformer { get; }
        void Select();
    }
}