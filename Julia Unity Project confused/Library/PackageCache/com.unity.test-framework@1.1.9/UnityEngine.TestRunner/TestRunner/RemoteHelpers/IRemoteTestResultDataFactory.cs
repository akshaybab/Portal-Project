<<<<<<< HEAD
using System;
using NUnit.Framework.Interfaces;

namespace UnityEngine.TestRunner.TestLaunchers
{
    internal interface IRemoteTestResultDataFactory
    {
        RemoteTestResultDataWithTestData CreateFromTestResult(ITestResult result);
        RemoteTestResultDataWithTestData CreateFromTest(ITest test);
    }
}
=======
using System;
using NUnit.Framework.Interfaces;

namespace UnityEngine.TestRunner.TestLaunchers
{
    internal interface IRemoteTestResultDataFactory
    {
        RemoteTestResultDataWithTestData CreateFromTestResult(ITestResult result);
        RemoteTestResultDataWithTestData CreateFromTest(ITest test);
    }
}
>>>>>>> 4692023cef52aa56104ab5e022258e42b3aa9d4e
