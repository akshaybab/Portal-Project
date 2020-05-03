<<<<<<< HEAD
using System.Collections;

namespace UnityEngine.TestTools
{
    public interface IEditModeTestYieldInstruction
    {
        bool ExpectDomainReload { get; }
        bool ExpectedPlaymodeState { get; }

        IEnumerator Perform();
    }
}
=======
using System.Collections;

namespace UnityEngine.TestTools
{
    public interface IEditModeTestYieldInstruction
    {
        bool ExpectDomainReload { get; }
        bool ExpectedPlaymodeState { get; }

        IEnumerator Perform();
    }
}
>>>>>>> 4692023cef52aa56104ab5e022258e42b3aa9d4e
