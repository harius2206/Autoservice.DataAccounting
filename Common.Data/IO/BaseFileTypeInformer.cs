using Common.Data.IO.Interfaces;

namespace Common.Data.IO
{
    public abstract class BaseFileTypeInformer : IFileTypeInformer
    {
        protected BaseFileTypeInformer(string fileTypeCaption, string fileExtension)
        {
            FileTypeCaption = fileTypeCaption;
            FileExtension = fileExtension;
        }

        public string FileTypeCaption { get; }
        public string FileExtension { get; }

        public string Key
        {
            get { return string.Format("{0} ({1})", FileTypeCaption, FileExtension); }
        }
    }
}