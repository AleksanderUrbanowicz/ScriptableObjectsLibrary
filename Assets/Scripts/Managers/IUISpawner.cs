using UnityEngine;

namespace BaseLibrary.Interfaces
{
    public interface IUISpawner
    {
        void RegisterUI(ISpawnable _spawnableUIData);
        GameObject InstantiateUI(ISpawnable _spawnableUI);


        void ToggleVisibility(string _id, bool b);

    }


}