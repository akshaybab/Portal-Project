<<<<<<< HEAD
namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    internal class TestFinishedMessage : Message
    {
        public string name;
        public TestState state;
        public string message;
        public ulong duration; // milliseconds
        public ulong durationMicroseconds;

        public TestFinishedMessage()
        {
            type = "TestStatus";
            phase = "End";
        }
    }
}
=======
namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    internal class TestFinishedMessage : Message
    {
        public string name;
        public TestState state;
        public string message;
        public ulong duration; // milliseconds
        public ulong durationMicroseconds;

        public TestFinishedMessage()
        {
            type = "TestStatus";
            phase = "End";
        }
    }
}
>>>>>>> 4692023cef52aa56104ab5e022258e42b3aa9d4e
