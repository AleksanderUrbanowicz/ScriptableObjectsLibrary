using System;
using UnityEngine;

namespace BaseLibrary.UI
{
    [Serializable]
    public class PluggableSprite
    {
        [PluggableAssetSelector(AssetTypeKey = "Sprite")]
        public string id;
        public Sprite sprite;
    }
}