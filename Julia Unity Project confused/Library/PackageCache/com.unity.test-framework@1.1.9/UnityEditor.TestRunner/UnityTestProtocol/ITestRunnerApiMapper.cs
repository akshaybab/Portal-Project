<<<<<<< HEAD
using System.Collections.Generic;
using UnityEditor.TestTools.TestRunner.Api;

namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    interface ITestRunnerApiMapper
    {
        string GetRunStateFromResultNunitXml(ITestResultAdaptor result);
        TestState GetTestStateFromResult(ITestResultAdaptor result);
        List<string> FlattenTestNames(ITestAdaptor testsToRun);
        TestPlanMessage MapTestToTestPlanMessage(ITestAdaptor testsToRun);
        TestStartedMessage MapTestToTestStartedMessage(ITestAdaptor test);
        TestFinishedMessage TestResultToTestFinishedMessage(ITestResultAdaptor result);
    }
}
=======
using System.Collections.Generic;
using UnityEditor.TestTools.TestRunner.Api;

namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    interface ITestRunnerApiMapper
    {
        string GetRunStateFromResultNunitXml(ITestResultAdaptor result);
        TestState GetTestStateFromResult(ITestResultAdaptor result);
        List<string> FlattenTestNames(ITestAdaptor testsToRun);
        TestPlanMessage MapTestToTestPlanMessage(ITestAdaptor testsToRun);
        TestStartedMessage MapTestToTestStartedMessage(ITestAdaptor test);
        TestFinishedMessage TestResultToTestFinishedMessage(ITestResultAdaptor result);
    }
}
>>>>>>> 4692023cef52aa56104ab5e022258e42b3aa9d4e
