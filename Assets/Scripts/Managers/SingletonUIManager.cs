using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Managers
{
    [CreateAssetMenu(fileName = "Manager_UI", menuName = "Managers/ Singleton UI Manager")]

    public class SingletonUIManager : ScriptableSingleton<SingletonUIManager>
    {
        public UI.ThemeUIData themeUI;

    }
}