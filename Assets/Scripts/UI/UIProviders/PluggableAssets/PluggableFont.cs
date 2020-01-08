using System;
using UnityEngine;
namespace BaseLibrary.UI
{
    [Serializable]
    public class PluggableFont
    {
        [PluggableAssetSelector(AssetTypeKey = "Font")]

        public string id;
        public Font font;
    }
}