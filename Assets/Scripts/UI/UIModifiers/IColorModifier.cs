namespace BaseLibrary.UI
{
    public interface IColorModifier : IUIModifier
    {
        void Awake();
        void SetColor(PluggableUIData uiData);
    }
}