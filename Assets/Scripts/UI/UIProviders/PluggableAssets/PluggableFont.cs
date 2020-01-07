using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UI
{
    [Serializable]
    public class PluggableFont
    {
        [PluggableAssetSelector(AssetTypeKey = "Font")]

        public string id;
        public Font font;
    }
}