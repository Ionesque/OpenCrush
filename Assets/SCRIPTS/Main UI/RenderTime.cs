using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;


public class RenderTime : MonoBehaviour
{
    public Universal U;
    public GUIStyle DrawRight;
    
    
    private void OnGUI()
    {
        string StrDate = DateTime.Now.ToString("h:mm:ss tt") + "\n"
            + DateTime.Now.ToString("MMMM dd, yyyy");
        GUI.Label(new Rect(U.Scale_X(0.0f), U.Scale_Y(0.91f), U.Scale_X(0.99f), U.Scale_Y(0.2f)), StrDate, DrawRight);
    }
}
