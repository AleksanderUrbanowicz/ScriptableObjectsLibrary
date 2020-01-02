using UnityEngine;
namespace Helpers
{

    public interface ISpawnable
    {
        GameObject GetPrefab { get; }

        string GetID { get; }
    }
}