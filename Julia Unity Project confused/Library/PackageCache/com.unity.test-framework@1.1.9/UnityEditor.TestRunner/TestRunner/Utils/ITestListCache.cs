<<<<<<< HEAD
using System.Collections.Generic;
using NUnit.Framework.Interfaces;
using UnityEditor.TestTools.TestRunner.Api;
using UnityEngine.TestTools;

namespace UnityEditor.TestTools.TestRunner
{
    interface ITestListCache
    {
        void CacheTest(TestPlatform platform, ITest test);
        IEnumerator<ITestAdaptor> GetTestFromCacheAsync(TestPlatform platform);
    }
}
=======
using System.Collections.Generic;
using NUnit.Framework.Interfaces;
using UnityEditor.TestTools.TestRunner.Api;
using UnityEngine.TestTools;

namespace UnityEditor.TestTools.TestRunner
{
    interface ITestListCache
    {
        void CacheTest(TestPlatform platform, ITest test);
        IEnumerator<ITestAdaptor> GetTestFromCacheAsync(TestPlatform platform);
    }
}
>>>>>>> 4692023cef52aa56104ab5e022258e42b3aa9d4e
