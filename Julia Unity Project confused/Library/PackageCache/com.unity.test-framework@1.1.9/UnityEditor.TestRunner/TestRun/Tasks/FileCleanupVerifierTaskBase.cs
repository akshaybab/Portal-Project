<<<<<<< HEAD
using System;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal abstract class FileCleanupVerifierTaskBase : TestTaskBase
    {
        internal Func<string[]> GetAllAssetPathsAction = AssetDatabase.GetAllAssetPaths;
        
        protected string[] GetAllFilesInAssetsDirectory()
        {
            return GetAllAssetPathsAction();
        }
    }
=======
using System;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal abstract class FileCleanupVerifierTaskBase : TestTaskBase
    {
        internal Func<string[]> GetAllAssetPathsAction = AssetDatabase.GetAllAssetPaths;
        
        protected string[] GetAllFilesInAssetsDirectory()
        {
            return GetAllAssetPathsAction();
        }
    }
>>>>>>> 4692023cef52aa56104ab5e022258e42b3aa9d4e
}