using BaseLibrary.UI;

namespace BaseLibrary.Interfaces
{
    public interface IColorModifier : IUIModifier
    {
        void Awake();
        void SetColor(PluggableUIData uiData);
    }
}