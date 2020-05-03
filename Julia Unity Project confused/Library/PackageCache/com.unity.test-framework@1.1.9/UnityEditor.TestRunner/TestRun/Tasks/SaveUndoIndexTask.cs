<<<<<<< HEAD
using System;
using System.Collections;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal class SaveUndoIndexTask : TestTaskBase
    {
        internal Func<int> GetUndoGroup = Undo.GetCurrentGroup;
        public override IEnumerator Execute(TestJobData testJobData)
        {
            testJobData.undoGroup = GetUndoGroup();
            yield break;
        }
    }
=======
using System;
using System.Collections;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal class SaveUndoIndexTask : TestTaskBase
    {
        internal Func<int> GetUndoGroup = Undo.GetCurrentGroup;
        public override IEnumerator Execute(TestJobData testJobData)
        {
            testJobData.undoGroup = GetUndoGroup();
            yield break;
        }
    }
>>>>>>> 4692023cef52aa56104ab5e022258e42b3aa9d4e
}