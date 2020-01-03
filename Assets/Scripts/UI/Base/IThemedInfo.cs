using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IThemedInfo
{
    Color GetColor(ThemeInfoType themedInfoType);
    Sprite GetSprite(ThemeInfoType themedInfoType);
}
