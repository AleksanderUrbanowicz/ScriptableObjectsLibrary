using System.Collections;
using System.Collections.Generic;
using UI;
using UnityEngine;
namespace UI
{
    public interface IColorModifier : IUIModifier
    {
        void SetColor(PluggableUIData uiData);
    }
}