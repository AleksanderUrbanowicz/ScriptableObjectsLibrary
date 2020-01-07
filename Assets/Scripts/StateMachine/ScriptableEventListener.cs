using UnityEngine;
using UnityEngine.Events;
namespace BaseLibrary.StateMachine
{
    public class ScriptableEventListener : MonoBehaviour
    {
        [Tooltip("Event to register with.")]
        public ScriptableEvent Event;

        [Tooltip("Response to invoke when Event is raised.")]
        public UnityEvent Response;

        public void Validate()
        {
            if (Event == null)
            {

                //   Destroy(this);
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
            else
            {


            }
        }


    }
}