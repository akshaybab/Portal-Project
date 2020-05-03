<<<<<<< HEAD
using UnityEngine;
using UnityEngine.TestTools.TestRunner;

namespace UnityEditor.TestTools.TestRunner.Api
{
    internal class CallbacksDelegatorListener : ScriptableObject, ITestRunnerListener
    {
        public void RunStarted(NUnit.Framework.Interfaces.ITest testsToRun)
        {
            CallbacksDelegator.instance.RunStarted(testsToRun);
        }

        public void RunFinished(NUnit.Framework.Interfaces.ITestResult testResults)
        {
            CallbacksDelegator.instance.RunFinished(testResults);
        }

        public void TestStarted(NUnit.Framework.Interfaces.ITest test)
        {
            CallbacksDelegator.instance.TestStarted(test);
        }

        public void TestFinished(NUnit.Framework.Interfaces.ITestResult result)
        {
            CallbacksDelegator.instance.TestFinished(result);
        }
    }
}
=======
using UnityEngine;
using UnityEngine.TestTools.TestRunner;

namespace UnityEditor.TestTools.TestRunner.Api
{
    internal class CallbacksDelegatorListener : ScriptableObject, ITestRunnerListener
    {
        public void RunStarted(NUnit.Framework.Interfaces.ITest testsToRun)
        {
            CallbacksDelegator.instance.RunStarted(testsToRun);
        }

        public void RunFinished(NUnit.Framework.Interfaces.ITestResult testResults)
        {
            CallbacksDelegator.instance.RunFinished(testResults);
        }

        public void TestStarted(NUnit.Framework.Interfaces.ITest test)
        {
            CallbacksDelegator.instance.TestStarted(test);
        }

        public void TestFinished(NUnit.Framework.Interfaces.ITestResult result)
        {
            CallbacksDelegator.instance.TestFinished(result);
        }
    }
}
>>>>>>> 4692023cef52aa56104ab5e022258e42b3aa9d4e
