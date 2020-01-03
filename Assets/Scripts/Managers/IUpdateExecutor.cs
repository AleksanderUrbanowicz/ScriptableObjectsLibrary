

namespace Managers
{
    public interface IUpdateExecutor : IExecutor
    {
        void StartExecute();
        void StopExecute();


        bool CheckUpdateConditions { get; }
        bool CheckPreConditions { get; }
    }
}