using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionVisualizer : MonoBehaviour
{
    private void OnGUI()
    {
        void Show(string text, TextAnchor align)
        {
            var rect = new Rect(x: 0, y: 100, Screen.width, Screen.height * 2 / 100);
            var style = new GUIStyle
            {
                alignment = align,
                fontSize = (int)rect.height,
                normal = { textColor = Color.red }
            };
            GUI.Label(rect, text, style);
        }
        Show(text: $"{transform.position}", align:TextAnchor.UpperLeft);
    }
}