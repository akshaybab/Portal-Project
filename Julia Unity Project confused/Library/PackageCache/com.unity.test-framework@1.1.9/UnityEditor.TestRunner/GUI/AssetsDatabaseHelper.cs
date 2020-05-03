<<<<<<< HEAD
namespace UnityEditor.TestTools.TestRunner.GUI
{
    internal class AssetsDatabaseHelper : IAssetsDatabaseHelper
    {
        public void OpenAssetInItsDefaultExternalEditor(string assetPath, int line)
        {
            var asset = AssetDatabase.LoadMainAssetAtPath(assetPath);
            AssetDatabase.OpenAsset(asset, line);
        }
    }
}
=======
namespace UnityEditor.TestTools.TestRunner.GUI
{
    internal class AssetsDatabaseHelper : IAssetsDatabaseHelper
    {
        public void OpenAssetInItsDefaultExternalEditor(string assetPath, int line)
        {
            var asset = AssetDatabase.LoadMainAssetAtPath(assetPath);
            AssetDatabase.OpenAsset(asset, line);
        }
    }
}
>>>>>>> 4692023cef52aa56104ab5e022258e42b3aa9d4e
