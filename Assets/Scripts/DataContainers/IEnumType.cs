using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Data
{
   
    public interface IEnumType
    {
        string GetEnumID();

        IEnumType[] GetAllInstances();

        bool Equals(IEnumType type);
    }
}