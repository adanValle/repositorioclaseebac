using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holaMundo : MonoBehaviour
{
    //int x;
    private void Awake()
    {
        Debug.Log("Hola desde Awake");
    }
    // Start is called before the first frame update
    void Start()
    {
        //x = 0;
        print("Impresión salida estandar a consola en Start");
        Debug.LogWarning("Advertencia en Start");
        Debug.LogError("Error en Start");
    }

    // Update is called once per frame
    void Update()
    {
        //x += 1;
        //Debug.Log("Value = " + x);

        Debug.Log("Hola desde Update");
    }

    private void FixedUpdate()
    {
        Debug.LogWarning("Hola desde FixedUpdate cada 50 frames");
    }

    private void LateUpdate()
    {
        Debug.Log("Hola desde LateUpdate");
    }

    private void OnEnable()
    {
        Debug.LogWarning("El objeto ha sido habilitado");
    }

    private void OnDisable()
    {
        Debug.Log("El objeto ha sido inhabilitado");
    }
}
