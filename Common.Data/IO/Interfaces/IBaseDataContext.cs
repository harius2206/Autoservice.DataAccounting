
using Common.Data.IO.Interfaces;

namespace Common.Data.Interfaces
{
    public interface IBaseDataContext : IBaseDataSet
    {
        bool Load();
        void Save();
    }
}
