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
        
        public UI.PluggableUIData currentTheme;
        public UI.PluggableUIData overrideTheme;
        public List<UI.PluggableUIData> themes ;

       // public List

        public PluggableUIData ThemeData
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