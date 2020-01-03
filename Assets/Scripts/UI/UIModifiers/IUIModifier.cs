using System.Collections;
using System.Collections.Generic;
using UI;
using UnityEngine;
namespace UI
{
    public interface IUIModifier
    {
        void Modify(IPlugginableUI plugginableUI, IPluggableUI pluggableUI, PluggableUIData themeData);
    }
}