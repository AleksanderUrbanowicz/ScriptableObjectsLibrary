using Data;
using Managers;
using StateMachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    [CreateAssetMenu(fileName = "Config_Global", menuName = "Config/Singleton Global Config")]
    public class SingletonGlobalConfig :  ScriptableSingleton<SingletonGlobalConfig>
    {

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void BeforeSceneLoad() { CreateSingletonInstance(); }

      
        public State buildObjectStartState;
        public State remainInState;

   
    }
}