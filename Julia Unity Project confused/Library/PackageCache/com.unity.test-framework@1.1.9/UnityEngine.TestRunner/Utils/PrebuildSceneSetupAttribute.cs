<<<<<<< HEAD
using System;

namespace UnityEngine.TestTools
{
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Method)]
    public class PrebuildSetupAttribute : Attribute
    {
        public PrebuildSetupAttribute(Type targetClass)
        {
            TargetClass = targetClass;
        }

        public PrebuildSetupAttribute(string targetClassName)
        {
            TargetClass = AttributeHelper.GetTargetClassFromName(targetClassName, typeof(IPrebuildSetup));
        }

        internal Type TargetClass { get; private set; }
    }
}
=======
using System;

namespace UnityEngine.TestTools
{
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Method)]
    public class PrebuildSetupAttribute : Attribute
    {
        public PrebuildSetupAttribute(Type targetClass)
        {
            TargetClass = targetClass;
        }

        public PrebuildSetupAttribute(string targetClassName)
        {
            TargetClass = AttributeHelper.GetTargetClassFromName(targetClassName, typeof(IPrebuildSetup));
        }

        internal Type TargetClass { get; private set; }
    }
}
>>>>>>> 4692023cef52aa56104ab5e022258e42b3aa9d4e
