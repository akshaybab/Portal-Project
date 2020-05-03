<<<<<<< HEAD
using System.Collections.Generic;
using UnityEngine.TestTools;
using UnityEngine.TestTools.Utils;

namespace UnityEditor.TestTools.TestRunner
{
    internal interface IEditorLoadedTestAssemblyProvider
    {
        List<IAssemblyWrapper> GetAssembliesGroupedByType(TestPlatform mode);
        IEnumerator<IDictionary<TestPlatform, List<IAssemblyWrapper>>> GetAssembliesGroupedByTypeAsync(TestPlatform mode);
    }
=======
using System.Collections.Generic;
using UnityEngine.TestTools;
using UnityEngine.TestTools.Utils;

namespace UnityEditor.TestTools.TestRunner
{
    internal interface IEditorLoadedTestAssemblyProvider
    {
        List<IAssemblyWrapper> GetAssembliesGroupedByType(TestPlatform mode);
        IEnumerator<IDictionary<TestPlatform, List<IAssemblyWrapper>>> GetAssembliesGroupedByTypeAsync(TestPlatform mode);
    }
>>>>>>> 4692023cef52aa56104ab5e022258e42b3aa9d4e
}