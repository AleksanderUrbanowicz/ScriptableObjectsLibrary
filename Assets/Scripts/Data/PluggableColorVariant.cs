using System;
using System.Collections;
using System.Collections.Generic;
using UI;
using UnityEngine;

[CreateAssetMenu(fileName = "Pluggable_ColorVariant_", menuName = "UI/Scriptable Enums/ColorVariant")]

public class PluggableColorVariant : ScriptableObject, IPluggableUI, IFontModifier
{
    public void GetFont()
    {
        throw new NotImplementedException();
    }

    public void GetSize()
    {
        throw new NotImplementedException();
    }

    public void Modify(IPlugginableUI plugginableUI, IPluggableUI pluggableUI, PluggableUIData pluggableUIData)
    {
        throw new NotImplementedException();
    }

    public void Plug(IPlugginableUI plugginable)
    {
        throw new NotImplementedException();
    }
}

