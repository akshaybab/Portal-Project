<<<<<<< HEAD
using System;
using System.Collections;
using NUnit.Framework.Interfaces;
using UnityEngine;
using UnityEngine.TestTools;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal class PrebuildSetupTask : BuildActionTaskBase<IPrebuildSetup>
    {
        public PrebuildSetupTask() : base(new PrebuildSetupAttributeFinder())
        {
        }

        protected override void Action(IPrebuildSetup target)
        {
            target.Setup();
        }
    }
=======
using System;
using System.Collections;
using NUnit.Framework.Interfaces;
using UnityEngine;
using UnityEngine.TestTools;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal class PrebuildSetupTask : BuildActionTaskBase<IPrebuildSetup>
    {
        public PrebuildSetupTask() : base(new PrebuildSetupAttributeFinder())
        {
        }

        protected override void Action(IPrebuildSetup target)
        {
            target.Setup();
        }
    }
>>>>>>> 4692023cef52aa56104ab5e022258e42b3aa9d4e
}