﻿using UI;
using UnityEngine;

[CreateAssetMenu(fileName = "ThemeMessageType_", menuName = "UI/Scriptable Enums/MessageType")]

public class PluggableMessageType : ScriptableObject, IPluggableUI
{

    string YES_NO_NEUTRAL_DEFAULT_INFO;

}

