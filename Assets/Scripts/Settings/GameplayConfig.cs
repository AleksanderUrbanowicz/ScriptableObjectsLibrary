﻿using DataContainers;
using Managers;
using Settings;
using StateMachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Configs
{ 
[CreateAssetMenu(fileName = "Config_Gameplay", menuName = "Config/Singleton Gameplay Config")]
    public class GameplayConfig : ScriptableSingleton<GameplayConfig>
    {
    public TransformRuntimeCollection AllPluggableTransforms;
    public UI.ThemeUIData themeUI;
        public GameplaySettings gameplaySettings;
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
       public static void BeforeSceneLoad() { CreateSingletonInstance(); }

        public void Init()
        {
            Debug.Log(GetType().Name + " Init.");

        }
    }
}