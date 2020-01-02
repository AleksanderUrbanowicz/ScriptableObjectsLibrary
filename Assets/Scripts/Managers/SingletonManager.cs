#if false
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Managers
{

    public class SingletonManager :  ScriptableSingleton<SingletonManager>
    {


        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void BeforeSceneLoad() { CreateSingletonInstance(); }

        public void Init()
        {
            Debug.Log(GetType().Name + " Init.");

        }

        public override void MonoBehaviourAwake()
        {
            Debug.Log(GetType().Name + " Awake.");

            Init();
        }


        private IEnumerator SimpleCoroutine()
        {
            while (true)
            {
                Debug.Log(GetType().Name + " coroutine test.");
                yield return new WaitForSeconds(3);
            }
        }
        public override void ScriptableObjectAwake()
        {
            Debug.Log(GetType().Name + " created.");
        }




        public override void Update()
        {

        }


        public override void FixedUpdate()
        {

        }
        protected static MonoBehaviour _MonoBehaviour;
        public static void CreateSingletonInstance() { ScriptableMonoBehaviour i = Instance; }
    }
}
#endif