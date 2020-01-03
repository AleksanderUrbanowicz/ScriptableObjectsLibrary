using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UI
{
    public interface ISpriteModifier :IUIModifier
    {
        void SetSprites(IPlugginableUI plugginableUI);


    }
}