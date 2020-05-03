<<<<<<< HEAD
using UnityEditor.TestTools.TestRunner.Api;
using UnityEngine;

namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    internal class UnityTestProtocolListener : ScriptableObject, ICallbacks
    {
        private IUtpMessageReporter m_UtpMessageReporter;

        public UnityTestProtocolListener()
        {
            m_UtpMessageReporter = new UtpMessageReporter(new UtpDebugLogger());
        }

        public void RunStarted(ITestAdaptor testsToRun)
        {
            m_UtpMessageReporter.ReportTestRunStarted(testsToRun);
        }

        public void RunFinished(ITestResultAdaptor testResults)
        {
            // Apparently does nothing :)
        }

        public void TestStarted(ITestAdaptor test)
        {
            m_UtpMessageReporter.ReportTestStarted(test);
        }

        public void TestFinished(ITestResultAdaptor result)
        {
            m_UtpMessageReporter.ReportTestFinished(result);
        }
    }
}
=======
using UnityEditor.TestTools.TestRunner.Api;
using UnityEngine;

namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    internal class UnityTestProtocolListener : ScriptableObject, ICallbacks
    {
        private IUtpMessageReporter m_UtpMessageReporter;

        public UnityTestProtocolListener()
        {
            m_UtpMessageReporter = new UtpMessageReporter(new UtpDebugLogger());
        }

        public void RunStarted(ITestAdaptor testsToRun)
        {
            m_UtpMessageReporter.ReportTestRunStarted(testsToRun);
        }

        public void RunFinished(ITestResultAdaptor testResults)
        {
            // Apparently does nothing :)
        }

        public void TestStarted(ITestAdaptor test)
        {
            m_UtpMessageReporter.ReportTestStarted(test);
        }

        public void TestFinished(ITestResultAdaptor result)
        {
            m_UtpMessageReporter.ReportTestFinished(result);
        }
    }
}
>>>>>>> 4692023cef52aa56104ab5e022258e42b3aa9d4e
