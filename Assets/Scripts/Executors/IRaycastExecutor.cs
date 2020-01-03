
namespace Managers
{
    public interface IRaycastExecutor : IUpdateExecutor
    {
        void Init(RaycastData raycastData);

        void GetHitInfo();
    }
}