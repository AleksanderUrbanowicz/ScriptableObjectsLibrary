using UnityEngine;
namespace BaseLibrary.Interfaces
{

    public interface ISpawnable
    {
        GameObject GetPrefab { get; }

        string GetID { get; }
    }
}