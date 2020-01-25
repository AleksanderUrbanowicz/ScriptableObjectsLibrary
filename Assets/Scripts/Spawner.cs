using BaseLibrary.Interfaces;
using UnityEngine;

namespace BaseLibrary.Implementations
{
    public class Spawner : ISpawner
    {


        public Spawner()
        {



        }

        public GameObject CreateInstance(Transform parent, Vector3 position, Quaternion rotation, ISpawnable _spawnable)
        {

            GameObject instance = Object.Instantiate(_spawnable.GetPrefab, position, rotation, parent);
            instance.name = _spawnable.GetID;
            return instance;
        }

    }
}