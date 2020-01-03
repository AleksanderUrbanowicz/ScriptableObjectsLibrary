using UnityEngine;
namespace Managers
{

    public interface ISpawnable
    {
        GameObject GetPrefab { get; }

        string GetID { get; }
    }
}