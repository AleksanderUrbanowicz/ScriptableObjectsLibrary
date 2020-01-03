using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI {
    [RequireComponent(typeof(Image))]

    
    public class ThemedImage : ThemeUI, IThemedInfo
    {
        [SerializeField]
        public ThemeInfoType themedInfoType;
        private Image image;

        public Image Image { get => image != null ? image : GetComponent<Image>(); }
                
         

        public Color GetColor(ThemeInfoType themedInfoType)
        {
            return Color.white;
        }

        public Sprite GetSprite(ThemeInfoType themedInfoType)
        {
          return  Image.sprite;
        }
    }
}