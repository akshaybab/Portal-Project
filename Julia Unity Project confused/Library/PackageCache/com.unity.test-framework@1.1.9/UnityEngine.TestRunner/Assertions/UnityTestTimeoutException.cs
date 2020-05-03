<<<<<<< HEAD
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace UnityEngine.TestTools.TestRunner
{
    internal class UnityTestTimeoutException : ResultStateException
    {
        public UnityTestTimeoutException(int timeout)
            : base(BuildMessage(timeout))
        {
        }

        private static string BuildMessage(int timeout)
        {
            return string.Format("UnityTest exceeded Timeout value of {0}ms", timeout);
        }

        public override ResultState ResultState
        {
            get { return ResultState.Failure; }
        }

        public override string StackTrace
        {
            get { return ""; }
        }
    }
}
=======
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace UnityEngine.TestTools.TestRunner
{
    internal class UnityTestTimeoutException : ResultStateException
    {
        public UnityTestTimeoutException(int timeout)
            : base(BuildMessage(timeout))
        {
        }

        private static string BuildMessage(int timeout)
        {
            return string.Format("UnityTest exceeded Timeout value of {0}ms", timeout);
        }

        public override ResultState ResultState
        {
            get { return ResultState.Failure; }
        }

        public override string StackTrace
        {
            get { return ""; }
        }
    }
}
>>>>>>> 4692023cef52aa56104ab5e022258e42b3aa9d4e
