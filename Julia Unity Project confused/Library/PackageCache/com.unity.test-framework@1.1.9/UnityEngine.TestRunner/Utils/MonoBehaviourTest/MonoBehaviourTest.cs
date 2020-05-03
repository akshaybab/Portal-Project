<<<<<<< HEAD
namespace UnityEngine.TestTools
{
    public class MonoBehaviourTest<T> : CustomYieldInstruction where T : MonoBehaviour, IMonoBehaviourTest
    {
        public T component { get; }
        public GameObject gameObject { get { return component.gameObject; } }

        public MonoBehaviourTest(bool dontDestroyOnLoad = true)
        {
            var go = new GameObject("MonoBehaviourTest: " + typeof(T).FullName);
            component = go.AddComponent<T>();
            if (dontDestroyOnLoad)
            {
                Object.DontDestroyOnLoad(go);
            }
        }

        public override bool keepWaiting
        {
            get { return !component.IsTestFinished; }
        }
    }
}
=======
namespace UnityEngine.TestTools
{
    public class MonoBehaviourTest<T> : CustomYieldInstruction where T : MonoBehaviour, IMonoBehaviourTest
    {
        public T component { get; }
        public GameObject gameObject { get { return component.gameObject; } }

        public MonoBehaviourTest(bool dontDestroyOnLoad = true)
        {
            var go = new GameObject("MonoBehaviourTest: " + typeof(T).FullName);
            component = go.AddComponent<T>();
            if (dontDestroyOnLoad)
            {
                Object.DontDestroyOnLoad(go);
            }
        }

        public override bool keepWaiting
        {
            get { return !component.IsTestFinished; }
        }
    }
}
>>>>>>> 4692023cef52aa56104ab5e022258e42b3aa9d4e
