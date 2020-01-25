using UnityEngine;

namespace BaseLibrary.DataContainers
{
    [CreateAssetMenu(fileName = "ScriptableBool", menuName = "Data/Collections/Scriptable Bool")]
    public class ScriptableBool : ScriptableObject
    {
        public bool value;
    }
}