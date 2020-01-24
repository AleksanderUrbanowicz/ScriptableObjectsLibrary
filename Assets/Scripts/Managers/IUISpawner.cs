using BaseLibrary.Data;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BaseLibrary.Managers
{
    public interface IUISpawner 
    {
        void RegisterUI(ISpawnable _spawnableUIData);
        GameObject InstantiateUI(ISpawnable _spawnableUI);


         void ToggleVisibility(string _id, bool b);

    }


}