<<<<<<< HEAD
using System;

namespace UnityEngine.TestTools.NUnitExtensions
{
    internal interface IStateSerializer
    {
        ScriptableObject RestoreScriptableObjectInstance();
        void RestoreClassFromJson(ref object instance);
        bool CanRestoreFromJson(Type requestedType);
        bool CanRestoreFromScriptableObject(Type requestedType);
    }
}
=======
using System;

namespace UnityEngine.TestTools.NUnitExtensions
{
    internal interface IStateSerializer
    {
        ScriptableObject RestoreScriptableObjectInstance();
        void RestoreClassFromJson(ref object instance);
        bool CanRestoreFromJson(Type requestedType);
        bool CanRestoreFromScriptableObject(Type requestedType);
    }
}
>>>>>>> 4692023cef52aa56104ab5e022258e42b3aa9d4e
