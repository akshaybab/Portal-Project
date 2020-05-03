<<<<<<< HEAD
using System;
using System.Linq;

namespace UnityEditor.TestRunner.CommandLineParser
{
    internal class CommandLineOption : ICommandLineOption
    {
        Action<string> m_ArgAction;

        public CommandLineOption(string argName, Action action)
        {
            ArgName = argName;
            m_ArgAction = s => action();
        }

        public CommandLineOption(string argName, Action<string> action)
        {
            ArgName = argName;
            m_ArgAction = action;
        }

        public CommandLineOption(string argName, Action<string[]> action)
        {
            ArgName = argName;
            m_ArgAction = s => action(SplitStringToArray(s));
        }

        public string ArgName { get; private set; }

        public void ApplyValue(string value)
        {
            m_ArgAction(value);
        }

        static string[] SplitStringToArray(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return null;
            }

            return value.Split(';').ToArray();
        }
    }
}
=======
using System;
using System.Linq;

namespace UnityEditor.TestRunner.CommandLineParser
{
    internal class CommandLineOption : ICommandLineOption
    {
        Action<string> m_ArgAction;

        public CommandLineOption(string argName, Action action)
        {
            ArgName = argName;
            m_ArgAction = s => action();
        }

        public CommandLineOption(string argName, Action<string> action)
        {
            ArgName = argName;
            m_ArgAction = action;
        }

        public CommandLineOption(string argName, Action<string[]> action)
        {
            ArgName = argName;
            m_ArgAction = s => action(SplitStringToArray(s));
        }

        public string ArgName { get; private set; }

        public void ApplyValue(string value)
        {
            m_ArgAction(value);
        }

        static string[] SplitStringToArray(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return null;
            }

            return value.Split(';').ToArray();
        }
    }
}
>>>>>>> 4692023cef52aa56104ab5e022258e42b3aa9d4e
