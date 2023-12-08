using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorGO4 : MonoBehaviour
{
    public bool var;
    private ColorGO1 go_cube;
    private ColorGO2 go_sphere;

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
        go_cube = GameObject.FindFirstObjectByType<ColorGO1>();
        go_sphere = GameObject.FindFirstObjectByType<ColorGO2>();
        var = go_cube.var || go_sphere.var;
        int rgb = var ? 255 : 0;
        Color color = new Color(rgb, rgb, rgb);

        Debug.Log("cube(" + go_cube.var + ") || sphere(" + go_sphere.var + ") -> capsule(" + var + "=" + (rgb == 255 ? "Blanco" : "Negro") + ")");
        GetComponent<Renderer>().material.color = color;
    }
}
