
using System;
using UnityEngine;

namespace BaseLibrary.UI
{
    [Serializable]
    public class PluggableColor
    {
        [PluggableAssetSelector(AssetTypeKey = "Color")]
        public string id;
        public Color color;
    }
}