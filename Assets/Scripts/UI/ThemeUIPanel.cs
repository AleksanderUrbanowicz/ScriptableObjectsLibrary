using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    [RequireComponent(typeof(Image))]
    public class ThemeUIPanel : ThemeUI
    {
        Image image;


        protected override void OnThemeDraw()
        {
            base.OnThemeDraw();
            image = GetComponent<Image>();



            
        }
    }
}