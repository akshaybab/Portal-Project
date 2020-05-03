<<<<<<< HEAD
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;

namespace UnityEngine.TestRunner.NUnitExtensions.Runner
{
    internal class PlaymodeWorkItemFactory : WorkItemFactory
    {
        protected override UnityWorkItem Create(TestMethod method, ITestFilter filter, ITest loadedTest)
        {
            return new CoroutineTestWorkItem(method, filter);
        }
    }
}
=======
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;

namespace UnityEngine.TestRunner.NUnitExtensions.Runner
{
    internal class PlaymodeWorkItemFactory : WorkItemFactory
    {
        protected override UnityWorkItem Create(TestMethod method, ITestFilter filter, ITest loadedTest)
        {
            return new CoroutineTestWorkItem(method, filter);
        }
    }
}
>>>>>>> 4692023cef52aa56104ab5e022258e42b3aa9d4e
