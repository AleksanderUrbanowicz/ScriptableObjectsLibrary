namespace BaseLibrary.Managers
{
    public interface IMonoBehaviourable
    {
        void MonoBehaviourAwake();
        void Start();
        void Update();
        void FixedUpdate();
    }
}