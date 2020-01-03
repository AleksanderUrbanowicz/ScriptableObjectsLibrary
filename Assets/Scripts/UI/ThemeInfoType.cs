using Data;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI
{
    [CreateAssetMenu(fileName = "ThemedInfo_", menuName = "UI/Themed Info Type")]

    [Serializable]
    public class ThemeInfoType : ScriptableObject, IEnumType, IThemedColor, IThemedSprite
    {
        public bool Equals(IEnumType type)
        {
            throw new NotImplementedException();
        }

        public IEnumType[] GetAllInstances()
        {
            throw new NotImplementedException();
        }


        public Sprite GetSprite()
        {
            throw new NotImplementedException();
        }

       

        string IEnumType.GetEnumID()
        {
            return (this as ScriptableObject).name;
        }

        void IThemedColor.SetColor()
        {
            throw new NotImplementedException();
        }
    }


}