﻿using StateMachine;
using UnityEditor;
using UnityEngine;

namespace StateMachine
{
    [CustomEditor(typeof(ScriptableEvent), true)]
    public class ScriptableEventEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GUI.enabled = Application.isPlaying;

            ScriptableEvent e = target as ScriptableEvent;
            if (GUILayout.Button("Raise"))
                e.Raise();
        }
    }

}