<<<<<<< HEAD
using Unity.CodeEditor;
using UnityEditor;

namespace Packages.Rider.Editor.PostProcessors
{
  public class RiderAssetPostprocessor: AssetPostprocessor
  {
    public static bool OnPreGeneratingCSProjectFiles()
    {
      var path = RiderScriptEditor.GetEditorRealPath(CodeEditor.CurrentEditorInstallation);
      if (RiderScriptEditor.IsRiderInstallation(path))
        return !ProjectGeneration.isRiderProjectGeneration;
      return false;
    }
  }
=======
using Unity.CodeEditor;
using UnityEditor;

namespace Packages.Rider.Editor.PostProcessors
{
  public class RiderAssetPostprocessor: AssetPostprocessor
  {
    public static bool OnPreGeneratingCSProjectFiles()
    {
      var path = RiderScriptEditor.GetEditorRealPath(CodeEditor.CurrentEditorInstallation);
      if (RiderScriptEditor.IsRiderInstallation(path))
        return !ProjectGeneration.isRiderProjectGeneration;
      return false;
    }
  }
>>>>>>> 4692023cef52aa56104ab5e022258e42b3aa9d4e
}