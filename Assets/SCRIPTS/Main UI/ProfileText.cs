using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfileText : MonoBehaviour
{
    public Universal U;
    public GUIStyle DrawLeft;

    private void OnGUI()
    {
        string StrProfile = "PLAYER NAME\n" + "$XXX,XXX,XXX,XXX\n";
        GUI.Label(new Rect(U.Scale_X(0.1f), U.Scale_Y(0.91f), U.Scale_X(0.99f), U.Scale_Y(0.2f)), StrProfile, DrawLeft);
        
    }
}
