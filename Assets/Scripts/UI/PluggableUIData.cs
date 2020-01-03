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
        public List<PluggableTextRole> pluggableTextRoles;
        public List<ScriptableObject> scriptableObjects=new List<ScriptableObject>();
        // Color Varoant
        //Text Role, ImageRole. informat type
        private void OnEnable()
        {
            
                InitData();
           // pluggableUIs



        }
        private void InitData()
        {

            var list = Resources.LoadAll<ScriptableObject>("").Where(x => x is IPluggableUI);
        }

    }
}