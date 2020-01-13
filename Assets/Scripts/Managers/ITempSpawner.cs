using GeneralImplementations.Data;
using UnityEngine;

namespace BaseLibrary.Managers
{
    public interface ITempSpawner : ISpawner
    {
        GameObject InstanceGameObject { get; }
        ISpawnableBuildObject SpawnableInstance { get; set; }
        void DestroyInstance();

        void ToggleInstance(bool b);
    }
}