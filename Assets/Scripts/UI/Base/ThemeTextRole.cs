using Data;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI
{

    [CreateAssetMenu(fileName = "ThemedColorVariant_", menuName = "UI/Themed Color Variant")]


    public class ThemeTextRole : ScriptableObject, IEnumType, IThemedFont
    {
        public bool Equals(IEnumType type)
        {
            throw new NotImplementedException();
        }

        public IEnumType[] GetAllInstances()
        {
            throw new NotImplementedException();
        }

        public void GetColor()
        {
            throw new NotImplementedException();
        }

        public string GetEnumID()
        {
            throw new NotImplementedException();
        }

        public void GetFont()
        {
            throw new NotImplementedException();
        }

        public void GetSize()
        {
            throw new NotImplementedException();
        }
    }


}
