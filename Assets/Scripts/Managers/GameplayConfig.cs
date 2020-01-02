using DataContainers;
using Managers;
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
 
}
}
