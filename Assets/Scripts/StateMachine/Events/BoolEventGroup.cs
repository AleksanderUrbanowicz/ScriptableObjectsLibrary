﻿using System;

namespace BaseLibrary.StateMachine
{
    [Serializable]
    public class BoolEventGroup
    {
        public string id;
        public ScriptableEvent scriptableEventTrue;
        public ScriptableEvent scriptableEventFalse;

        public BoolEventGroup()
        {
        }
        public BoolEventGroup(ScriptableEvent[] events)
        {
            scriptableEventTrue = events[0];
            scriptableEventFalse = events[1];
        }
        /*
        public BoolEventGroup(ScriptableEvent _scriptableEventTrue, ScriptableEvent _scriptableEventFalse)
        {
            scriptableEventTrue = _scriptableEventTrue;
            scriptableEventFalse = _scriptableEventFalse;
        }
    */
    }
}
