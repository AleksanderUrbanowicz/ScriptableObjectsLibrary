using Data;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UI {

    [CreateAssetMenu(fileName = "ThemedColorVariant_", menuName = "UI/Themed Color Variant")]

    [Serializable]
    public class ThemeColorVariant : ScriptableObject, IEnumType, IThemedColor
    {
        public bool Equals(IEnumType type)
        {
            throw new NotImplementedException();
        }

        public IEnumType[] GetAllInstances()
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
