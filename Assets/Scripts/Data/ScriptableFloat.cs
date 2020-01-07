using UnityEngine;

namespace BaseLibrary.Data
{
    [CreateAssetMenu(fileName = "ScriptableFloat", menuName = "Data/Collections/Scriptable Float")]
    public class ScriptableFloat : ScriptableObject
    {
        public float value;
    }
}