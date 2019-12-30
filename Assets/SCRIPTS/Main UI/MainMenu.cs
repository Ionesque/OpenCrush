using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{

    public Universal U;
    public GUIStyle Normal;
    public GUIStyle Normal_Right;
    public GUIStyle Selected;

    enum menu
    {
        Off,
        Main,
        Singleplayer,
        Freeroam,
        Multiplayer,
        Editor,
        Options,
        CustomContent
    }

    string StrBrief = "Select Option";

    string StrMenus = "Main Menu";

    string[] Main_Strings = new string[6]
    {
        "Single Player",
        "Free Roam",
        "Multi Player",
        "Editor",
        "Options",
        "Additional Content"
    };

    menu currentMenus = menu.Main;

    int selectionOption = 0;
    int maxOption = 5;

    private void OnGUI()
    {
        float y = 0.18f;

        GUI.Label(new Rect(U.Scale_X(0.03f), U.Scale_Y(0.02f), U.Scale_X(0.99f), U.Scale_Y(0.1f)), StrBrief, Normal);
        GUI.Label(new Rect(U.Scale_X(0.03f), U.Scale_Y(0.02f), U.Scale_X(0.94f), U.Scale_Y(0.1f)), StrMenus, Normal_Right);

        for (int i = 0; i < 6; i++)
        {
            if(i == selectionOption) GUI.Label(new Rect(U.Scale_X(0.03f), U.Scale_Y(y), U.Scale_X(0.99f), U.Scale_Y(0.1f)), Main_Strings[i], Selected);
            else GUI.Label(new Rect(U.Scale_X(0.03f), U.Scale_Y(y), U.Scale_X(0.99f), U.Scale_Y(0.1f)), Main_Strings[i], Normal);
            y += 0.1f;
        }
    }
}
