<<<<<<< HEAD
using NUnit.Framework.Interfaces;

namespace UnityEngine.TestTools.TestRunner
{
    internal class TestListenerWrapper : ITestListener
    {
        private readonly TestFinishedEvent m_TestFinishedEvent;
        private readonly TestStartedEvent m_TestStartedEvent;

        public TestListenerWrapper(TestStartedEvent testStartedEvent, TestFinishedEvent testFinishedEvent)
        {
            m_TestStartedEvent = testStartedEvent;
            m_TestFinishedEvent = testFinishedEvent;
        }

        public void TestStarted(ITest test)
        {
            m_TestStartedEvent.Invoke(test);
        }

        public void TestFinished(ITestResult result)
        {
            m_TestFinishedEvent.Invoke(result);
        }

        public void TestOutput(TestOutput output)
        {
        }
    }
}
=======
using NUnit.Framework.Interfaces;

namespace UnityEngine.TestTools.TestRunner
{
    internal class TestListenerWrapper : ITestListener
    {
        private readonly TestFinishedEvent m_TestFinishedEvent;
        private readonly TestStartedEvent m_TestStartedEvent;

        public TestListenerWrapper(TestStartedEvent testStartedEvent, TestFinishedEvent testFinishedEvent)
        {
            m_TestStartedEvent = testStartedEvent;
            m_TestFinishedEvent = testFinishedEvent;
        }

        public void TestStarted(ITest test)
        {
            m_TestStartedEvent.Invoke(test);
        }

        public void TestFinished(ITestResult result)
        {
            m_TestFinishedEvent.Invoke(result);
        }

        public void TestOutput(TestOutput output)
        {
        }
    }
}
>>>>>>> 4692023cef52aa56104ab5e022258e42b3aa9d4e
