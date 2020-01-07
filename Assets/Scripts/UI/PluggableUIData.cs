using Data;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
namespace UI
{
    [CreateAssetMenu(fileName = "Theme_", menuName = "UI/Theme UI Data")]
    public class PluggableUIData : ScriptableObject
    {

      
        public List<PluggableColor> Colors;
        public List<PluggableSprite> Sprites;
        public List<PluggableFont> Fonts;

        public Color defaultColor;
        public Sprite defaultSprite;
        public Font defaultFont;
        private void OnEnable()
        {
            
               
          
        }

        public Color GetColor(string id)
        {
            if (Colors.FirstOrDefault(x => x.id == id) == null)
            {

                return defaultColor;
            }

            Color c=  Colors.FirstOrDefault(x => x.id == id).color;
            if(c==null)
            {

                c = defaultColor;
            }
            return c;
        }

        public Sprite GetSprite(string id)
        {
            if(Sprites.FirstOrDefault(x => x.id == id)==null)
            {

                return defaultSprite;
            }


            Sprite s = Sprites.FirstOrDefault(x => x.id == id).sprite;
            if (s == null)
            {

                s = defaultSprite;
            }
            return s;
        }

        public Font GetFont(string id)
        {
            if (Fonts.FirstOrDefault(x => x.id == id) == null)
            {

                return defaultFont;
            }

            Font f = Fonts.FirstOrDefault(x => x.id == id).font;
            if (f == null)
            {

                f = defaultFont;
            }
            return f;
        }
    }
}