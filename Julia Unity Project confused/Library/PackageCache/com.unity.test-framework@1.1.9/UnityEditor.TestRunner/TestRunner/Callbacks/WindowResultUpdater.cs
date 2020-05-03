<<<<<<< HEAD
using UnityEditor.TestTools.TestRunner.Api;

namespace UnityEditor.TestTools.TestRunner.GUI
{
    internal class WindowResultUpdater : ICallbacks, ITestTreeRebuildCallbacks
    {
        public void RunStarted(ITestAdaptor testsToRun)
        {
        }

        public void RunFinished(ITestResultAdaptor testResults)
        {
            if (TestRunnerWindow.s_Instance != null)
            {
                TestRunnerWindow.s_Instance.RebuildUIFilter();
            }
        }

        public void TestStarted(ITestAdaptor testName)
        {
        }

        public void TestFinished(ITestResultAdaptor test)
        {
            if (TestRunnerWindow.s_Instance == null)
            {
                return;
            }   

            var result = new TestRunnerResult(test);
            TestRunnerWindow.s_Instance.m_SelectedTestTypes.UpdateResult(result);
        }

        public void TestTreeRebuild(ITestAdaptor test)
        {
            if (TestRunnerWindow.s_Instance == null)
            {
                return;
            }
            
            TestRunnerWindow.s_Instance.m_SelectedTestTypes.UpdateTestTree(test);
        }
    }
}
=======
using UnityEditor.TestTools.TestRunner.Api;

namespace UnityEditor.TestTools.TestRunner.GUI
{
    internal class WindowResultUpdater : ICallbacks, ITestTreeRebuildCallbacks
    {
        public void RunStarted(ITestAdaptor testsToRun)
        {
        }

        public void RunFinished(ITestResultAdaptor testResults)
        {
            if (TestRunnerWindow.s_Instance != null)
            {
                TestRunnerWindow.s_Instance.RebuildUIFilter();
            }
        }

        public void TestStarted(ITestAdaptor testName)
        {
        }

        public void TestFinished(ITestResultAdaptor test)
        {
            if (TestRunnerWindow.s_Instance == null)
            {
                return;
            }   

            var result = new TestRunnerResult(test);
            TestRunnerWindow.s_Instance.m_SelectedTestTypes.UpdateResult(result);
        }

        public void TestTreeRebuild(ITestAdaptor test)
        {
            if (TestRunnerWindow.s_Instance == null)
            {
                return;
            }
            
            TestRunnerWindow.s_Instance.m_SelectedTestTypes.UpdateTestTree(test);
        }
    }
}
>>>>>>> 4692023cef52aa56104ab5e022258e42b3aa9d4e
