using BaseLibrary.Data;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BaseLibrary.Managers
{
    public interface IUISpawner 
    {
        void RegisterUI(SpawnableUIData _spawnableUIData);
        GameObject InstantiateUI(SpawnableUIData _spawnableUI);


         void ToggleVisibility(string _id, bool b);

    }


}