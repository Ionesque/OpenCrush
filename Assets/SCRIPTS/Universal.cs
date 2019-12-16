using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// High-use functions for use on multiple scripts
/// </summary>
public class Universal : MonoBehaviour
{
    /// <summary>
    /// Keep this alive at all times
    /// </summary>
    private void Start()
    {
        DontDestroyOnLoad(this);
    }

    /// <summary>
    /// Scales UI elements to the current screen resolution on the X-axis
    /// </summary>
    /// <param name="x">0.0f = Left, 1.0f = Right</param>
    /// <returns></returns>
    public float Scale_X(float x)
    {
        return x / Screen.width;
    }

    /// <summary>
    /// Scales UI elements to the current screen resolution on the Y-axis
    /// </summary>
    /// <param name="y">0.0f = Top, 1.0f = Bottom</param>
    /// <returns></returns>
    public float Scale_Y(float y)
    {
        return y / Screen.height;
    }
}
