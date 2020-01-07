﻿


using BaseLibrary.StateMachine;
using UnityEditor;
using UnityEngine;

namespace StateMachine
{
    [CustomEditor(typeof(GameEvent), true)]
    public class EventEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GUI.enabled = Application.isPlaying;

            GameEvent e = target as GameEvent;
            if (GUILayout.Button("Raise"))
                e.Raise();
        }
    }
}