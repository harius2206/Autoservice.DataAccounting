using System;

namespace Common.Data.Interfaces
{
    public interface IDataChangeable
    {
        event EventHandler<EventArgs> DataChanged;
    }
}
