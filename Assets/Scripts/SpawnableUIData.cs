using BaseLibrary.Interfaces;
using UnityEngine;

namespace BaseLibrary.DataContainers
{

    [CreateAssetMenu(fileName = "SpawnableUIData_", menuName = "UI/Spawnable UI Data")]

    public class SpawnableUIData : ScriptableObject, ISpawnable
    {
        public string id;
        public GameObject objectPrefab;
        public GameObject GetPrefab => objectPrefab;

        public string GetID => id;

        public bool isVisible;
       
    }
}