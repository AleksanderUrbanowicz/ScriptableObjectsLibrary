
using UnityEngine;
using Executors;

namespace Managers
{
    [CreateAssetMenu(fileName = "Manager_Select", menuName = "Managers/ Singleton Select Manager")]
    public class SingletonSelectManager : ScriptableSingleton<SingletonSelectManager> 
    {
      //  public RaycastExecutor raycastExecutor;
        public RaycastData raycastData;
        //  public BoolEventListener hitMissListeners;

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void BeforeSceneLoad() { CreateSingletonInstance(); }

        public void Init()
        {
            Debug.Log(GetType().Name + " Init.");

        }



        public override void MonoBehaviourAwake()
        {
            Debug.Log(GetType().Name + " Awake.");

           // Init();
        }

        public void InitEventListeners()
        {
           // hitMissListeners = new BoolEventListener("SelectManagerHit", _MonoBehaviour.gameObject.transform, raycastData.hitMissEvents.scriptableEventTrue, HandleFocusHit, raycastData.hitMissEvents.scriptableEventFalse, HandleFocusMiss);

        }

        public void InitRaycaster()
        {
     

        }


        private void HandleFocusMiss()
        {
            Debug.LogError("HandleFocusMiss");


        }

        private void HandleFocusHit()
        {
            Debug.LogError("HandleFocusHit");



        }
        //protected // static MonoBehaviour _MonoBehaviour;
       // public  static void CreateSingletonInstance() { ScriptableMonoBehaviour i = Instance; }

    }
}
