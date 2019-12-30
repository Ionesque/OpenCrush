using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderGradient : MonoBehaviour
{
    public Material GradientFast;
    public Material GradientSlow;

    float xFast = 0.0f;
    float xSlow = 0.0f;

    // Update is called once per frame
    void Update()
    {
        xFast += Time.deltaTime;
        xSlow += Time.deltaTime * 0.35f;
        GradientFast.SetTextureOffset("_MainTex", new Vector2(xFast, 0.0f));
        GradientSlow.SetTextureOffset("_MainTex", new Vector2(xSlow, 0.0f));
    }
}
