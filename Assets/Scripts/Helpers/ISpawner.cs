
using UnityEngine;
namespace Helpers
{
    public interface ISpawner
    {
        GameObject CreateInstance(Transform parent, Vector3 position, Quaternion rotation, ISpawnable spawnable = null);
    }
}