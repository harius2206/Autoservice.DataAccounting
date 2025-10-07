using System;
using Common.Data.IO.Interfaces;
using Common.Interfaces;

namespace Common.Data.IO
{
    public class FileTypeSelector : IFileTypeSelector
    {
        private readonly IFileTypeInformer[] _fileTypeInformers;

        public IFileTypeInformer CurrentInformer { get; private set; }
        public Func<IKeyable[], string, IKeyable> KeyableSelector { get; set; }

        public FileTypeSelector(IFileTypeInformer[] fileTypeInformers, Func<IKeyable[], string, IKeyable> keySelector)
        {
            if (fileTypeInformers == null || fileTypeInformers.Length == 0)
                throw new ArgumentException("Масив інформерів не може бути порожнім.", nameof(fileTypeInformers));

            _fileTypeInformers = fileTypeInformers;
            CurrentInformer = _fileTypeInformers[0];
            KeyableSelector = keySelector ?? throw new ArgumentNullException(nameof(keySelector));
        }

        public void Select()
        {
            IKeyable selectedObj = KeyableSelector(_fileTypeInformers, $"Виберіть тип файлу ({CurrentInformer.Key})");
            if (selectedObj == null)
                return;

            CurrentInformer = selectedObj as IFileTypeInformer;
        }
    }
}