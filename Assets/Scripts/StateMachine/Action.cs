using UnityEngine;
namespace BaseLibrary.StateMachine

{
    public abstract class Action : ScriptableObject
    {
        public abstract void Act(StateControllerMBBase controller);
        public int interval;
    }
}