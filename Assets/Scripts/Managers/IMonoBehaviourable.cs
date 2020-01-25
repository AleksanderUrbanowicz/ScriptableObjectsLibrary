namespace BaseLibrary.Interfaces
{
    public interface IMonoBehaviourable
    {
        void MonoBehaviourAwake();
        void Start();
        void Update();
        void FixedUpdate();
    }
}