<<<<<<< HEAD
namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    internal class TestStartedMessage : Message
    {
        public string name;
        public TestState state;

        public TestStartedMessage()
        {
            type = "TestStatus";
            phase = "Begin";
            state = TestState.Inconclusive;
        }
    }
}
=======
namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    internal class TestStartedMessage : Message
    {
        public string name;
        public TestState state;

        public TestStartedMessage()
        {
            type = "TestStatus";
            phase = "Begin";
            state = TestState.Inconclusive;
        }
    }
}
>>>>>>> 4692023cef52aa56104ab5e022258e42b3aa9d4e
