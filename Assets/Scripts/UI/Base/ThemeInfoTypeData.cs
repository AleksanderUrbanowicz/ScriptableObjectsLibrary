using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UI
{
    [Serializable]
    public class ThemeInfoTypeData : IEnumTypeData
    {
        public  ThemeInfoType themeInfoID;
        public Color color;
        public Sprite icon;

        public ThemeInfoTypeData(ThemeInfoType themeInfoID)
        {
            this.themeInfoID = themeInfoID;
        }

        public void Initialize(IEnumType enumType)
        {
           
        }
    }
}
