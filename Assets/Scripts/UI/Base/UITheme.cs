using Data;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
namespace UI
{
    [CreateAssetMenu(fileName = "Theme_", menuName = "UI/Theme UI Data")]
    public class UITheme : ScriptableObject
    {
        public List<IEnumValue> values = new List<IEnumValue>();
        
    
        // Color Varoant
        //Text Role, ImageRole. informat type
        private void OnEnable()
        {
            if(values == null)
            {
                InitData();
            }
            

        }
        private void InitData()
        { }

    }
}