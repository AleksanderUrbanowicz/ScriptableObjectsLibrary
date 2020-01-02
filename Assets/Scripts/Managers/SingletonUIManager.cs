using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UI;
namespace Managers
{
    [CreateAssetMenu(fileName = "Manager_UI", menuName = "Managers/ Singleton UI Manager")]

    public class SingletonUIManager : ScriptableSingleton<SingletonUIManager>
    {

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void BeforeSceneLoad() { CreateSingletonInstance(); }
        public float n = 30;
        public UI.ThemeUIData currentTheme;
        public UI.ThemeUIData overrideTheme;
        public List<UI.ThemeUIData> themes ;

        public ThemeUIData Theme
        {
            get { if (overrideTheme == null)
                {

                    return currentTheme;
                }
            else
                {
                    return overrideTheme;
                }
                }
            set { }
        }
    }
}