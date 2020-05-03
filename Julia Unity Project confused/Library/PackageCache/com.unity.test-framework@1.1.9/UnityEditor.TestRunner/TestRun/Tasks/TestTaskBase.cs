<<<<<<< HEAD
using System.Collections;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal abstract class TestTaskBase
    {
        public bool SupportsResumingEnumerator;

        protected TestTaskBase(bool supportsResumingEnumerator = false)
        {
            SupportsResumingEnumerator = supportsResumingEnumerator;
        }

        public abstract IEnumerator Execute(TestJobData testJobData);
    }
=======
using System.Collections;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal abstract class TestTaskBase
    {
        public bool SupportsResumingEnumerator;

        protected TestTaskBase(bool supportsResumingEnumerator = false)
        {
            SupportsResumingEnumerator = supportsResumingEnumerator;
        }

        public abstract IEnumerator Execute(TestJobData testJobData);
    }
>>>>>>> 4692023cef52aa56104ab5e022258e42b3aa9d4e
}