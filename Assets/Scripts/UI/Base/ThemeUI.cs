using Configs;
using Managers;
using UnityEngine;

namespace UI
{
    [ExecuteInEditMode]
    public class ThemeUI : MonoBehaviour
    {
        public ThemeUIData themeData;
        
        //public ControlSize controlSize;
        public RectTransform controlRect;
        //public float relativeWidth=1.0f;
        public Vector2 relativeSize = Vector2.one;

        public ThemeUIData ThemeData
        {
            get
            {

                themeData = themeData != null ? themeData : SingletonUIManager.Instance.Theme;
                return themeData;
               // return SingletonUIManager.Instance.overrideTheme !=null ? SingletonUIManager.Instance.overrideTheme : 

                // return Config.GlobalConfig.overrideTheme != null ? Config.GlobalConfig.overrideTheme : themeData;

            }


        }

        protected virtual void OnThemeDraw()
        {


        }

        public virtual void Awake()
        {
            
            OnThemeDraw();
        }
        public virtual void Update()
        {

            if (Application.isEditor)
            {

                OnThemeDraw();
            }
        }
    }
}