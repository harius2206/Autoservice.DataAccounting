using Common.Entities;
using Common.Interfaces;

namespace Common.Data.IO.Interfaces
{
    public interface IFileTypeInformer : IKeyable
    {
        string FileTypeCaption { get; }
        string FileExtension { get; }
    }
}