using UnityEngine;

namespace BaseLibrary.Managers
{
    public class ScriptableSingleton<T, U> : ScriptableMonoBehaviour where T : ScriptableMonoBehaviour where U : MonoBehaviourHookup
    {
        private static T _instance;
        private static bool _instantiated;
        public static T Instance
        {
            get
            {
                if (_instantiated) return _instance;
                var singletonName = typeof(T).Name;

                var assets = Resources.LoadAll<T>("");
                if (assets.Length == 0)
                {
                    _instance = CreateInstance<T>();
                    //Debug.LogError("CreateInstance<"+ typeof(T).Name+">" );
                }
                else
                {
                    _instance = assets[0];
                }
                _instantiated = true;
                var go = new GameObject(typeof(T).Name);
                go.SetActive(false);
                U monoBehaviourHookup = go.AddComponent<U>();

                // MonoBehaviourHookup monoBehaviourHookup = go.AddComponent<MonoBehaviourHookup>();
                monoBehaviourHookup.Parent = _instance;
                _MonoBehaviour = monoBehaviourHookup;
                DontDestroyOnLoad(_MonoBehaviour.gameObject);
                monoBehaviourHookup.gameObject.SetActive(true); //Awake
                return _instance;
            }
        }

        public static T EditorInstance
        {
            get
            {



                var assets = Resources.FindObjectsOfTypeAll<T>();
                return assets[0];
            }
        }

        protected static MonoBehaviour _MonoBehaviour;
        public static void CreateSingletonInstance() { ScriptableMonoBehaviour i = Instance; }
        private void OnDestroy() { _instantiated = false; }
    }
}