namespace BaseLibrary.UI
{
    public interface IUIModifier
    {
        void Modify(IPlugginableUI plugginableUI, IPluggableUI pluggableUI, PluggableUIData themeData);
    }
}