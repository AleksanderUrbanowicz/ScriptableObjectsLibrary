using Data;
using Managers;
using UnityEngine;

namespace UI
{
    [ExecuteInEditMode]
    public class ThemeUI : MonoBehaviour
    {
        public UITheme themeData;
        
        
        public Vector2 relativeSize = Vector2.one;

        public UITheme ThemeData
        {
            get
            {

                themeData = themeData != null ? themeData : SingletonUIManager.Instance.Theme;
                return themeData;
              
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