<<<<<<< HEAD
using System;
using System.Linq;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal.Filters;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools.TestRunner.GUI;

namespace UnityEngine.TestTools.TestRunner
{
    [Serializable]
    internal class PlaymodeTestsControllerSettings
    {
        [SerializeField]
        public TestRunnerFilter[] filters;
        public bool sceneBased;
        public string originalScene;
        public string bootstrapScene;

        public static PlaymodeTestsControllerSettings CreateRunnerSettings(TestRunnerFilter[] filters)
        {
            var settings = new PlaymodeTestsControllerSettings
            {
                filters = filters,
                sceneBased = false,
                originalScene = SceneManager.GetActiveScene().path,
                bootstrapScene = null
            };
            return settings;
        }

        internal ITestFilter BuildNUnitFilter()
        {
            return new OrFilter(filters.Select(f => f.BuildNUnitFilter()).ToArray());
        }
    }
}
=======
using System;
using System.Linq;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal.Filters;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools.TestRunner.GUI;

namespace UnityEngine.TestTools.TestRunner
{
    [Serializable]
    internal class PlaymodeTestsControllerSettings
    {
        [SerializeField]
        public TestRunnerFilter[] filters;
        public bool sceneBased;
        public string originalScene;
        public string bootstrapScene;

        public static PlaymodeTestsControllerSettings CreateRunnerSettings(TestRunnerFilter[] filters)
        {
            var settings = new PlaymodeTestsControllerSettings
            {
                filters = filters,
                sceneBased = false,
                originalScene = SceneManager.GetActiveScene().path,
                bootstrapScene = null
            };
            return settings;
        }

        internal ITestFilter BuildNUnitFilter()
        {
            return new OrFilter(filters.Select(f => f.BuildNUnitFilter()).ToArray());
        }
    }
}
>>>>>>> 4692023cef52aa56104ab5e022258e42b3aa9d4e
