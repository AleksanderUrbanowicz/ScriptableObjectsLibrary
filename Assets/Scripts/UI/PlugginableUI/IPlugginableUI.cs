using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Managers;
using UI;
namespace UI
{
    public interface IPlugginableUI
    {

        void PlugData(IPluggableUI pluggableUI, PluggableUIData themeData);

    }
}