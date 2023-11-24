using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorGO1 : MonoBehaviour
{
    private void Awake()
    {
        Color randomColor = new Color(Random.value, Random.value, Random.value);
        GetComponent<Renderer>().material.color = randomColor;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
