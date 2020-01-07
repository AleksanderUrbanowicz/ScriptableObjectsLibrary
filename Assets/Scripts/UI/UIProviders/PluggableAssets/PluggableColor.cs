
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI
{
    [Serializable]
    public class PluggableColor
    {
        [PluggableAssetSelector(AssetTypeKey = "Color")]
        public string id;
        public Color color;
    }
}