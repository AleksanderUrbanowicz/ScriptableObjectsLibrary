using UnityEngine;
namespace BaseLibrary.Interfaces
{
    public interface ISpawner
    {
        GameObject CreateInstance(Transform parent, Vector3 position, Quaternion rotation, ISpawnable spawnable = null);
    }
}