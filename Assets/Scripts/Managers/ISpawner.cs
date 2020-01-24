using BaseLibrary.Data;
using UnityEngine;
namespace BaseLibrary.Managers
{
    public interface ISpawner
    {
        GameObject CreateInstance(Transform parent, Vector3 position, Quaternion rotation, ISpawnable spawnable = null);
    }
}