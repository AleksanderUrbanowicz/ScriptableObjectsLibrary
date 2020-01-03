using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI {
    [RequireComponent(typeof(Image))]

    
    public class PlugginableImage : ThemeUI, IPlugginableUI, IColorModifier, ISpriteModifier
    {
        [SerializeField]
        public PluggableMessageType themedMessageType;
        [SerializeField]
        public PluggableColorVariant themeColorVariant;
   
        private Image image;

        public Image Image { get => image != null ? image : GetComponent<Image>(); }

        public Color ApplyModifier(Color color)
        {
            throw new NotImplementedException();
        }

        public void Modify(IPlugginableUI plugginableUI, IPluggableUI pluggableUI, PluggableUIData themeData)
        {
            throw new NotImplementedException();
        }

       

        public void SetColor(PluggableUIData uiData)
        {
            throw new NotImplementedException();
        }

        public void SetSprites(IPlugginableUI plugginableUI)
        {
            throw new NotImplementedException();
        }

        protected override void OnThemeDraw()
        {

            base.OnThemeDraw();
            Image.color = Color.red;

        }



    }
}