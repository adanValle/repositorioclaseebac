using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorGO5 : MonoBehaviour
{
    public bool var;
    private ColorGO3 go_3;
    private ColorGO4 go_4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        go_3 = GameObject.FindFirstObjectByType<ColorGO3>();
        go_4 = GameObject.FindFirstObjectByType<ColorGO4>();
        var = go_3.var || go_4.var;
        int rgb = var ? 255 : 0;
        Color color = new Color(rgb, rgb, rgb);

        Debug.Log("go_3(" + go_3.var + ") || go_4(" + go_4.var + ") -> go_5(" + var + "=" + (rgb == 255 ? "Blanco" : "Negro") + ")");
        GetComponent<Renderer>().material.color = color;
    }
}
