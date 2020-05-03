<<<<<<< HEAD
using System.Text;

namespace UnityEditor.TestTools.TestRunner
{
    internal class PlayerLauncherBuildOptions
    {
        public BuildPlayerOptions BuildPlayerOptions;
        public string PlayerDirectory;

        public override string ToString()
        {
            var str = new StringBuilder();
            str.AppendLine("locationPathName = " + BuildPlayerOptions.locationPathName);
            str.AppendLine("target = " + BuildPlayerOptions.target);
            str.AppendLine("scenes = " + string.Join(", ", BuildPlayerOptions.scenes));
            str.AppendLine("assetBundleManifestPath = " + BuildPlayerOptions.assetBundleManifestPath);
            str.AppendLine("options.Development = " + ((BuildPlayerOptions.options & BuildOptions.Development) != 0));
            str.AppendLine("options.AutoRunPlayer = " + ((BuildPlayerOptions.options & BuildOptions.AutoRunPlayer) != 0));
            str.AppendLine("options.ForceEnableAssertions = " + ((BuildPlayerOptions.options & BuildOptions.ForceEnableAssertions) != 0));
            return str.ToString();
        }
    }
}
=======
using System.Text;

namespace UnityEditor.TestTools.TestRunner
{
    internal class PlayerLauncherBuildOptions
    {
        public BuildPlayerOptions BuildPlayerOptions;
        public string PlayerDirectory;

        public override string ToString()
        {
            var str = new StringBuilder();
            str.AppendLine("locationPathName = " + BuildPlayerOptions.locationPathName);
            str.AppendLine("target = " + BuildPlayerOptions.target);
            str.AppendLine("scenes = " + string.Join(", ", BuildPlayerOptions.scenes));
            str.AppendLine("assetBundleManifestPath = " + BuildPlayerOptions.assetBundleManifestPath);
            str.AppendLine("options.Development = " + ((BuildPlayerOptions.options & BuildOptions.Development) != 0));
            str.AppendLine("options.AutoRunPlayer = " + ((BuildPlayerOptions.options & BuildOptions.AutoRunPlayer) != 0));
            str.AppendLine("options.ForceEnableAssertions = " + ((BuildPlayerOptions.options & BuildOptions.ForceEnableAssertions) != 0));
            return str.ToString();
        }
    }
}
>>>>>>> 4692023cef52aa56104ab5e022258e42b3aa9d4e
