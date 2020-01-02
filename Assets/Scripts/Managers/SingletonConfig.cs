#if false
using Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Configs

{
    public class SingletonConfig : ScriptableSingleton<SingletonConfig>
    {


        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void BeforeSceneLoad() { CreateSingletonInstance(); }

        public void Init()
        {
            Debug.Log(GetType().Name + " Init.");

        }

   
     
        public override void ScriptableObjectAwake()
        {
            Debug.Log(GetType().Name + " created.");
        }

        protected  static MonoBehaviour _MonoBehaviour;
        public  static void CreateSingletonInstance() { ScriptableMonoBehaviour i = Instance; }

    }
}
#endif