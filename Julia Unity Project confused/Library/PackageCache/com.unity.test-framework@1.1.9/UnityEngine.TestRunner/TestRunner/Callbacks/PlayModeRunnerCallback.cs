<<<<<<< HEAD
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace UnityEngine.TestTools.TestRunner.Callbacks
{
    [AddComponentMenu("")]
    internal class PlayModeRunnerCallback : MonoBehaviour, ITestRunnerListener
    {
        private TestResultRenderer m_ResultRenderer;

        public void RunFinished(ITestResult testResults)
        {
            Application.logMessageReceivedThreaded -= LogRecieved;
            if (Camera.main == null)
            {
                gameObject.AddComponent<Camera>();
            }
            m_ResultRenderer = new TestResultRenderer(testResults);
            m_ResultRenderer.ShowResults();
        }

        public void TestFinished(ITestResult result)
        {
        }

        public void OnGUI()
        {
            if (m_ResultRenderer != null)
                m_ResultRenderer.Draw();
        }

        public void RunStarted(ITest testsToRun)
        {
            Application.logMessageReceivedThreaded += LogRecieved;
        }

        public void TestStarted(ITest test)
        {
        }

        private void LogRecieved(string message, string stacktrace, LogType type)
        {
            if (TestContext.Out != null)
                TestContext.Out.WriteLine(message);
        }
    }
}
=======
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace UnityEngine.TestTools.TestRunner.Callbacks
{
    [AddComponentMenu("")]
    internal class PlayModeRunnerCallback : MonoBehaviour, ITestRunnerListener
    {
        private TestResultRenderer m_ResultRenderer;

        public void RunFinished(ITestResult testResults)
        {
            Application.logMessageReceivedThreaded -= LogRecieved;
            if (Camera.main == null)
            {
                gameObject.AddComponent<Camera>();
            }
            m_ResultRenderer = new TestResultRenderer(testResults);
            m_ResultRenderer.ShowResults();
        }

        public void TestFinished(ITestResult result)
        {
        }

        public void OnGUI()
        {
            if (m_ResultRenderer != null)
                m_ResultRenderer.Draw();
        }

        public void RunStarted(ITest testsToRun)
        {
            Application.logMessageReceivedThreaded += LogRecieved;
        }

        public void TestStarted(ITest test)
        {
        }

        private void LogRecieved(string message, string stacktrace, LogType type)
        {
            if (TestContext.Out != null)
                TestContext.Out.WriteLine(message);
        }
    }
}
>>>>>>> 4692023cef52aa56104ab5e022258e42b3aa9d4e
