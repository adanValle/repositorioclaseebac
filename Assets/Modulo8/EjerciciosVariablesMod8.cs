using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    private int mi_int = 0;
    private float mi_float = 1;

    void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //#1.2
        float numeroFloat1 = 10.5f;
        float numeroFloat2 = 3.7f;

        float resultadoFloat = numeroFloat1 / numeroFloat2;
        int resultadoEntero = (int)resultadoFloat;
        Debug.Log($"resultadoFloat: {resultadoFloat}; CasteoExplícito: {resultadoEntero}");

        //#1.5
        float numeroFlotante = 12.456789123f;
        string numeroComoString = numeroFlotante.ToString("F4");
        Debug.Log($"flotante = {numeroFlotante}; comoString = {numeroComoString}");

        //#1.6
        string miNombre = "Adán Valle Pacheco";
        string nombre = miNombre.Substring(0, 4);
        string apellido1 = miNombre.Substring(5, 5);
        string apellido2 = miNombre.Substring(11, 7);
        Debug.Log($"{nombre} {apellido1} {apellido2}");

        string[] nombreArreglo = miNombre.Split(" ");
        foreach (string palabra in nombreArreglo)
        {
            Debug.Log(palabra);
        }

        //#2.1
        string valor1 = "15000", valor2 = "5000";
        int val1, val2;
        if (int.TryParse(valor1, out val1) && int.TryParse(valor2, out val2))
        {
            Debug.Log($"suma de valores numéricos parseados = {val1 + val2}");
        }

        //#2.2
        string miString = "Hola Mundo";
        for (int i = 0; i<miString.Length; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log($"Caracter con índice par: {miString[i]}");
            }
        }

        //#2.3
        string otroString = "Pepe pica papas con un pico";
        Debug.Log(otroString.Substring(4, otroString.Length - 4));
    }

    // Update is called once per frame
    void Update()
    {
        //#1.1
        mi_int++;
        Debug.Log($"Mi valor entero: {mi_int}");

        //#1.3
        meshRenderer.material.color = (mi_int % 2 == 0) ? Color.white : Color.black;
    }

    void FixedUpdate()
    {
        //#1.1
        mi_float*=2;
        Debug.Log($"Mi valor flotante: {mi_float}");

        //#1.4
        string odd = (UnityEngine.Random.Range(0, 101) % 2 == 0) ? "par" : "impar";
        switch (odd)
        {
            case "par":
                meshRenderer.material.color = Color.white;
                break;
            case "impar":
                meshRenderer.material.color = Color.black;
                break;
        }
    }
}
