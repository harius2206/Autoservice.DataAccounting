using Common.Interfaces;
using Common.Processing.Types;

namespace Common.Processing.Events {
    public class CrudActionEventArgs {
        public readonly CrudMode CrudMode;
        public readonly IKeyable KeyableObject;

        public CrudActionEventArgs(CrudMode crudMode, IKeyable keyableObject) {
            CrudMode = crudMode;
            KeyableObject = keyableObject;
        }

    }
}
