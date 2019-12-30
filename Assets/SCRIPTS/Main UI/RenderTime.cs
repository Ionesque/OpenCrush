using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderTime : MonoBehaviour
{
    public Universal U;
    public GUIStyle DrawRight;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(U.Scale_X(0.0f), U.Scale_Y(0.8f), U.Scale_X(1.0f), U.Scale_Y(0.2f)), "TIME TEST", DrawRight);
    }
}
