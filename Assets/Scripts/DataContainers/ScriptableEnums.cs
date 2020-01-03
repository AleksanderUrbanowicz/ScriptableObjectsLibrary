using Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
namespace Data
{
    [Serializable]
    public class ScriptableEnums<T, U>  where T : IEnumValue where U : ScriptableObject, IEnumType
    {
        public List<T> enumDatas;
        public U u;

        private void OnEnable()
        {
            init();
            ValidateKeys();
        }
        public void init()
        {
            enumDatas = new List<T>();
            var assets = Resources.LoadAll<U>("");
            if (assets.Length == 0)
            {
                Debug.LogError("no ThemeInfoType");
            }
            foreach (U type in assets)
            {
                T t = default(T);
                if(t !=null)
                    {
                    t.Initialize(type);
                }
                enumDatas.Add(t);
              //  Debug.LogError("enum add: "+type.GetEnumID());
            }
        }
        
            public void ValidateKeys()
        {
            enumDatas = new List<T>();
            //Debug.LogError("ValidateKeys");

            var assets = Resources.LoadAll<U>("");
            if (assets.Length == 0)
            {
                Debug.LogError("no ThemeInfoType");
            }
            foreach (U type in assets)
            {
                string s = type.GetEnumID();
             

               // if (enumDatas.FirstOrDefault(w => w.GetEnumKey() == s) == null)// GetEnumKey()==type.GetEnumID()))
               // {
                    T t = default(T);
                   // t.Initialize(type);
                    enumDatas.Add(t);
                //}

            }
        }
    }
}