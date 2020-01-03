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
        public List<ThemeInfoEnumValue> infoVals;
        public List<ThemeInfoType> infoTypes;
        // Color Varoant
        //Text Role, ImageRole. informat type
        private void OnEnable()
        {
            if(infoVals ==null)
            {
                InitData();
            }
            

        }
        private void InitData()
        {
            infoVals = new List<ThemeInfoEnumValue>();
           
            infoTypes = Resources.LoadAll<ThemeInfoType>("").ToList();

            //values = Resources.LoadAll<(ScriptableObject)>("").ToList();
            foreach (var n in infoTypes)
            {

                //Resources.Load < Types(n)> ("");
                values.Add(new ThemeInfoEnumValue(n as IEnumType));
            }

            foreach (var n in infoTypes)
            {

                infoVals.Add(new ThemeInfoEnumValue(n as IEnumType));
            }
        }

    }
}