<<<<<<< HEAD
namespace UnityEngine.TestTools.Logging
{
    internal class LogEvent
    {
        public string Message { get; set; }

        public string StackTrace { get; set; }

        public LogType LogType { get; set; }

        public bool IsHandled { get; set; }

        public override string ToString()
        {
            return string.Format("[{0}] {1}", LogType, Message);
        }
    }
}
=======
namespace UnityEngine.TestTools.Logging
{
    internal class LogEvent
    {
        public string Message { get; set; }

        public string StackTrace { get; set; }

        public LogType LogType { get; set; }

        public bool IsHandled { get; set; }

        public override string ToString()
        {
            return string.Format("[{0}] {1}", LogType, Message);
        }
    }
}
>>>>>>> 4692023cef52aa56104ab5e022258e42b3aa9d4e
