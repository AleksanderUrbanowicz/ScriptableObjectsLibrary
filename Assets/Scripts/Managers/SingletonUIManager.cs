﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UI;
using System.Linq;

namespace Managers
{
    [CreateAssetMenu(fileName = "Manager_UI", menuName = "Managers/ Singleton UI Manager")]

    public class SingletonUIManager : ScriptableSingleton<SingletonUIManager>
    {

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void BeforeSceneLoad() { CreateSingletonInstance(); }
        
        public UI.PluggableUIData currentPluggableUI;
        public UI.PluggableUIData overridePluggableUI;
        public List<UI.PluggableUIData> pluggableUIs;
        public List<ScriptableObject> scriptableObjects;
        private void OnEnable()
        {

            InitData();

        }
        private void InitData()
        {

            scriptableObjects = Resources.LoadAll<ScriptableObject>("").Where(x => x is IPluggableUI).ToList();

            
        }

        public PluggableUIData PluggableUIData
        {
            get { if (overridePluggableUI == null)
                {

                    return currentPluggableUI;
                }
            else
                {
                    return overridePluggableUI;
                }
                }
            set { }
        }
    }
}