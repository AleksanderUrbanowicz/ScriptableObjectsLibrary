using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    [RequireComponent(typeof(Button))]
    [RequireComponent(typeof(Image))]
    public class ThemeUIButton : ThemeUI
    {
        Image image;
        Button button;
        public int size;
        public Image iconImage;
        public Image.Type buttonType;
        public Text text;

        public Image[] images;
        protected override void OnThemeDraw()
        {
            base.OnThemeDraw();

         

            

        }


        private void SetButtonImages()
        {

        
        

        }
    }
}