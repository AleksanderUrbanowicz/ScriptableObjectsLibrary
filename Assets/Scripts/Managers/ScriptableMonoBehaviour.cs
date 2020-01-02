using UnityEngine;

namespace Managers
{
    public class ScriptableMonoBehaviour : ScriptableObject, IMonoBehaviourable
    {
        public void Awake() { ScriptableObjectAwake(); }
        public virtual void ScriptableObjectAwake() { }
        public virtual void MonoBehaviourAwake() { }
        public virtual void Start() { }
        public virtual void Update() { }
        public virtual void FixedUpdate() { }
    }

}
