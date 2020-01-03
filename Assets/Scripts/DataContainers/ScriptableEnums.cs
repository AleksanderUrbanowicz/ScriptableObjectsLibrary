using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableEnums<T,U> : ScriptableObject where T : IEnumTypeData where U :ScriptableObject
{
    public List<T> infoTypeDatas;

    public void init()
    {
        infoTypeDatas = new List<T>();
        var assets = Resources.LoadAll<U>("");
        if (assets.Length == 0)
        {
            Debug.LogError("no ThemeInfoType");
        }
        foreach (U type in assets)
        {
           // T t;
           // infoTypeDatas.Add(t);
        }
    }
}
