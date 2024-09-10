using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace TestMod
{
    public static class Watermark
    {
        
        public static void Call()
        {

            GUIStyle style = new GUIStyle(GUI.skin.label);

            style.fontSize = 14;
            style.alignment = TextAnchor.UpperCenter;
            style.normal.textColor = Color.blue;

            GUI.Label(new Rect(0, 0, Screen.width, 100), "Content Warning by .dxxns", style);
            float fps = 1.0f / Time.deltaTime;
            string fpsText = "FPS: " + Mathf.RoundToInt(fps);

            Rect rect = new Rect(0, 0 + 20, Screen.width, 100); // Adjust height as needed

            GUI.Label(rect, fpsText, style);
            Rect rect1 = new Rect(0, 0 + 40, Screen.width, 100); // Adjust height as needed
        }
    }
}
