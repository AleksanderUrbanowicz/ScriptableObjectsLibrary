using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI {
    [RequireComponent(typeof(Image))]

    
    public class ThemedImage : ThemeUI
    {
        [SerializeField]
        public ThemeInfoType themedInfoType;
        [SerializeField]
        public ThemeColorVariant themeColorVariant;
   
        private Image image;

        public Image Image { get => image != null ? image : GetComponent<Image>(); }

        protected override void OnThemeDraw()
        {

            base.OnThemeDraw();
            
        }



    }
}