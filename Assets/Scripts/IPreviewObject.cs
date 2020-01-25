using UnityEngine;

namespace BaseLibrary.Interfaces
{
    public interface IPreviewObject
    {
        GameObject GameObjectInstance { get; }
        BoxCollider PreviewCollider { get; }
        MeshRenderer PreviewRenderer { get; }
        void ToggleVisibility(bool b);

        //void Init(ISpawnableBuildObject spawnableBuildObject);
    }
}