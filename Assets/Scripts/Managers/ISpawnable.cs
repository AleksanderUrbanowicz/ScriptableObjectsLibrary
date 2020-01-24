using UnityEngine;
namespace BaseLibrary.Data
{

    public interface ISpawnable
    {
        GameObject GetPrefab { get; }

        string GetID { get; }
    }
}