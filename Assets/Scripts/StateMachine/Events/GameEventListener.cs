﻿using UnityEngine;
using UnityEngine.Events;
namespace BaseLibrary.StateMachine
{
    public class GameEventListener : MonoBehaviour
    {
        [Tooltip("Event to register with.")]
        public GameEvent Event;

        [Tooltip("Response to invoke when Event is raised.")]
        public UnityEvent Response;

        private void OnEnable()
        {
            if (Event == null)
            {

                // Debug.Log("GameEventListener:  Event == null");
                Destroy(this);
            }
            else
            {
                Event.RegisterListener(this);
            }
        }

        private void OnDisable()
        {
            if (Event != null)
            {
                Event.UnregisterListener(this);
            }
        }

        public void OnEventRaised()
        {

            if (Response != null)
            {
                Response.Invoke();
            }
           
        }

    }
}