<<<<<<< HEAD
using System.Collections;
using System.Linq;
using UnityEngine.TestTools.TestRunner;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal class LegacyPlayModeRunTask : TestTaskBase
    {
        public LegacyPlayModeRunTask() : base(true)
        {
            
        }
        public override IEnumerator Execute(TestJobData testJobData)
        {
            var settings = PlaymodeTestsControllerSettings.CreateRunnerSettings(testJobData.executionSettings.filters.Select(filter => filter.ToTestRunnerFilter()).ToArray());
            var launcher = new PlaymodeLauncher(settings);
            
            launcher.Run();

            while (PlaymodeLauncher.IsRunning)
            {
                yield return null;
            }
        }
    }
=======
using System.Collections;
using System.Linq;
using UnityEngine.TestTools.TestRunner;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal class LegacyPlayModeRunTask : TestTaskBase
    {
        public LegacyPlayModeRunTask() : base(true)
        {
            
        }
        public override IEnumerator Execute(TestJobData testJobData)
        {
            var settings = PlaymodeTestsControllerSettings.CreateRunnerSettings(testJobData.executionSettings.filters.Select(filter => filter.ToTestRunnerFilter()).ToArray());
            var launcher = new PlaymodeLauncher(settings);
            
            launcher.Run();

            while (PlaymodeLauncher.IsRunning)
            {
                yield return null;
            }
        }
    }
>>>>>>> 4692023cef52aa56104ab5e022258e42b3aa9d4e
}