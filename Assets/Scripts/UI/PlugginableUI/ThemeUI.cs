using Data;
using Managers;
using UnityEngine;

namespace UI
{
    [ExecuteInEditMode]
    public class ThemeUI : MonoBehaviour, IPlugginableUI
    {
        public PluggableUIData themeData;
        public PluggableUIData ThemeData
        {
            get
            {

                themeData = themeData != null ? themeData : SingletonUIManager.Instance.ThemeData;
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

        public PluggableUIData GetPluggableUIData(IPluggableUI pluggableUI)
        {
            throw new System.NotImplementedException();
        }

        public void PlugData(IPluggableUI pluggableUI, PluggableUIData themeData)
        {
            throw new System.NotImplementedException();
        }
    }
}