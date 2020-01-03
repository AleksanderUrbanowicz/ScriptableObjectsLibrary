using Data;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
namespace UI
{
    [CreateAssetMenu(fileName = "Theme_", menuName = "UI/Theme UI Data")]
    public class PluggableUIData : ScriptableObject
    {
        public PluggableColorVariant pluggableColorVariant;
        public PluggableTextRole  pluggableTextRole;
        [SerializeField]
        public List<ScriptableObject> pluggableUIs;
        public List<ScriptableObject> scriptableObjects;
        
        private void OnEnable()
        {
            
                InitData();
          
        }
        private void InitData()
        {
            pluggableUIs = Resources.LoadAll<ScriptableObject>("").Where(x => x is IPluggableUI).ToList();
            
        }

    }
}