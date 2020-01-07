using UnityEngine;
namespace BaseLibrary.Managers
{

    public interface ISpawnable
    {
        GameObject GetPrefab { get; }

        string GetID { get; }
    }
}