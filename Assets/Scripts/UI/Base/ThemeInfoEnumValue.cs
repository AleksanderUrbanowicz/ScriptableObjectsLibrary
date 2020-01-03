using DataContainers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
namespace UI
{
    [Serializable]
    public class ThemeInfoEnumValue : IEnumValue, IThemedColor, IThemedSprite
    {
        [SerializeField]
        public ThemeInfoType enumKey;
        public Color color;
        public Sprite icon;

        public ThemeInfoEnumValue(IEnumType themeInfoID)
        {
            this.enumKey = (themeInfoID as ThemeInfoType);
        }


        public ThemeInfoEnumValue()
        {
            
        }

        public void Initialize(IEnumType enumType)
        {
            this.enumKey = enumType as ThemeInfoType;
            this.color = Color.white;
        }

        public string GetEnumKey()
        {
            throw new NotImplementedException();
        }

        public IEnumType GetEnum()
        {
            
            return enumKey;

        }

        public void SetColor()
        {
            throw new NotImplementedException();
        }

        public Sprite GetSprite()
        {
            throw new NotImplementedException();
        }
    }
}
