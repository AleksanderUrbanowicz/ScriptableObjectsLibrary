using BaseLibrary.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BaseLibrary.Data
{
    public interface ISpawnableUI : ISpawnable
    {
         void ToggleVisibility(bool b);
    }
}