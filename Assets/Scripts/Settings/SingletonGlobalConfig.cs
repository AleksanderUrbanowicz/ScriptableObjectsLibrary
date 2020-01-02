﻿using DataContainers;
using Managers;
using StateMachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Configs
{
    [CreateAssetMenu(fileName = "Config_Global", menuName = "Config/Singleton Global Config")]
    public class SingletonGlobalConfig :  ScriptableSingleton<SingletonGlobalConfig>
    {

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void BeforeSceneLoad() { CreateSingletonInstance(); }

        public void Init()
        {
            Debug.Log(GetType().Name + " Init.");

        }

        public TransformRuntimeCollection AllPluggableTransforms;
        public UI.ThemeUIData themeUI;
        public State buildObjectStartState;
        public State remainInState;

   
    }
}