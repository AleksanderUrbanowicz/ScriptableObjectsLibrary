using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI
{
    [Serializable]
    public class PluggableSprite
    {
        [PluggableAssetSelector(AssetTypeKey = "Sprite")]
        public string id;
        public Sprite sprite;
    }
}