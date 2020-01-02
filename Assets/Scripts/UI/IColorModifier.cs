using UnityEngine;

namespace UI
{
    public interface IColorModifier
    {
        Color ApplyModifier(Color color);
    }
}