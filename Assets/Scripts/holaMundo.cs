using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holaMundo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Impresión salida estandar a consola");
        Debug.Log("Algo sucedió");
        Debug.LogWarning("Advertencia");
        Debug.LogError("Error");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
