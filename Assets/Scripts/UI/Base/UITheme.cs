using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UI
{
    [CreateAssetMenu(fileName = "Theme_", menuName = "UI/Theme UI Data")]
    public class UITheme : ScriptableObject
    {
        public ThemeInfoTypeData themeInfoTypeData;
        public List<ThemeInfoTypeData> infoTypeDatas;

        public void OnEnable()
        {
            //infoTypeDatas = new List<ThemeInfoTypeData>();
            var assets = Resources.LoadAll<ThemeInfoType>("");
            if (assets.Length == 0)
            {
                Debug.LogError("no ThemeInfoType");
            }
            foreach(ThemeInfoType type in assets)
            {
                infoTypeDatas.Add(new ThemeInfoTypeData(type));
            }
        }

        
    }
}