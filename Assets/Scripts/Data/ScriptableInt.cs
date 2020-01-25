using UnityEngine;

namespace BaseLibrary.DataContainers
{

    [CreateAssetMenu(fileName = "ScriptableInt", menuName = "Data/Collections/Scriptable Int")]
    public class ScriptableInt : ScriptableObject
    {
        public bool value;
    }
}