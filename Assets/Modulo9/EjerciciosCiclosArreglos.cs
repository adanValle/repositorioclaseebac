using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;

public class EjerciciosCiclosArreglos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //#1
        int[] primerArreglo = new int[5];
        int[] segundoArreglo = new int[5];
        int[] tercerArreglo = new int[5];

        for (int i = 0; i < primerArreglo.Length; i++)
        {
            primerArreglo[i] = UnityEngine.Random.Range(1, 11);
            segundoArreglo[i] = UnityEngine.Random.Range(1, 11);
            tercerArreglo[i] = primerArreglo[i] + segundoArreglo[i];
            UnityEngine.Debug.Log($"{primerArreglo[i]} + {segundoArreglo[i]} = {tercerArreglo[i]}");
        }

        //#2
        string[] arregloString = { "Creando", "una", "oración", "con", "un", "arreglo", "de", "strings", ":)" };
        string oracion = "";
        foreach (string palabra in arregloString) 
        {
            oracion += $"{palabra} ";
        }
        UnityEngine.Debug.Log(oracion);

        //#3
        int n = 2, m = 3, p = 1;
        int[,] matriz1 = new int[n, m];
        int[,] matriz2 = new int[m, p];
        

        for (int i = 0; i < matriz1.GetLength(0); i++)
        {
            for (int j = 0; j < matriz1.GetLength(1); j++)
            {
                matriz1[i, j] = UnityEngine.Random.Range(1, 11);
            }
        }

        for (int i = 0; i < matriz2.GetLength(0); i++)
        {
            for (int j = 0; j < matriz2.GetLength(1); j++)
            {
                matriz2[i, j] = UnityEngine.Random.Range(1, 11);
            }
        }

        //       2x3              3x1                          2x1
        // [ a00 a01 a02 ]  \/  [ b00 ]  -  [ a00*b00 + a01*b10 + a02*b20 = c00 ]
        // [ a10 a11 a12 ]  /\  [ b10 ]  -  [ a10*b00 + a11*b10 + a12*b20 = c10 ]
        //                      [ b20 ]

        int[,] matrizR = new int[matriz1.GetLength(0), matriz2.GetLength(1)];

        for (int i = 0; i < matriz1.GetLength(0); i++)
        {
            for (int j = 0; j < matriz2.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < m; k++)
                {
                    sum += matriz1[i, k] * matriz2[k, j];
                }
                matrizR[i, j] = sum;
                UnityEngine.Debug.Log(matrizR[i, j]);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
