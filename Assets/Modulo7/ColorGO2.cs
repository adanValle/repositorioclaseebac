using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorGO2 : MonoBehaviour
{
    public bool var;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Color randomColor = new Color(Random.value, Random.value, Random.value);
        //GetComponent<Renderer>().material.color = randomColor;
    }

    private void FixedUpdate()
    {
        int rand = Random.Range(0, 2);
        var = rand == 1 ? true : false;
        int rgb = !var ? 255 : 0;
        Color color = new Color(rgb, rgb, rgb);

        Debug.Log(
            "GO2(Sphere)\n" +
            "valor inicial = " + var +
            " -> !valor inicial = " + !var +
            " -> color = " + (rgb == 255 ? "Blanco" : "Negro")
        );

        GetComponent<Renderer>().material.color = color;
    }
}
