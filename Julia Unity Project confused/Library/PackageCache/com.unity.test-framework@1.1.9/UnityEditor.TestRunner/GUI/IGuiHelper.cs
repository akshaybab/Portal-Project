<<<<<<< HEAD
using System;
using System.Reflection;

namespace UnityEditor.TestTools.TestRunner.GUI
{
    internal interface IGuiHelper
    {
        bool OpenScriptInExternalEditor(string stacktrace);
        void OpenScriptInExternalEditor(Type type, MethodInfo method);
        IFileOpenInfo GetFileOpenInfo(Type type, MethodInfo method);
        string FilePathToAssetsRelativeAndUnified(string filePath);
    }
}
=======
using System;
using System.Reflection;

namespace UnityEditor.TestTools.TestRunner.GUI
{
    internal interface IGuiHelper
    {
        bool OpenScriptInExternalEditor(string stacktrace);
        void OpenScriptInExternalEditor(Type type, MethodInfo method);
        IFileOpenInfo GetFileOpenInfo(Type type, MethodInfo method);
        string FilePathToAssetsRelativeAndUnified(string filePath);
    }
}
>>>>>>> 4692023cef52aa56104ab5e022258e42b3aa9d4e
