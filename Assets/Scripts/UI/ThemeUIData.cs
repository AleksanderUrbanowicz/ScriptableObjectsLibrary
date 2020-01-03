using UnityEngine;


namespace UI
{
    [CreateAssetMenu(fileName = "ThemeUI_", menuName = "ScriptableSystems/UI System/Theme UI Data")]

    public class ThemeUIData : ScriptableObject
    {
        const float space = 4.0f;

        public string id;
    
        public Color blendColorOverride = Color.white;

        private void OnEnable()
        {
         
        }
    }
}