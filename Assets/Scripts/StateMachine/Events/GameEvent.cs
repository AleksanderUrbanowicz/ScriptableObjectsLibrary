using System.Collections.Generic;
using UnityEngine;

namespace BaseLibrary.StateMachine
{
    [CreateAssetMenu(fileName = "GameEvent", menuName = "States/Game Event")]

    public class GameEvent : ScriptableObject
    {
        public string id;

       
        private readonly List<GameEventListener> eventListeners =
            new List<GameEventListener>();

        public virtual void Raise()
        {
            for (int i = eventListeners.Count - 1; i >= 0; i--)
                eventListeners[i].OnEventRaised();
        }

        public virtual void RegisterListener(GameEventListener listener)
        {
            if (!eventListeners.Contains(listener))
                eventListeners.Add(listener);
        }

        public virtual void UnregisterListener(GameEventListener listener)
        {
            if (eventListeners.Contains(listener))
                eventListeners.Remove(listener);
        }
    }
}