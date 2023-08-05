using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Hola desde Awake");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.LogWarning("Hola desde Start");
    }

    // Update is called once per frame
    void Update()
    {
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
        Debug.LogError("El objeto ha sido inhabilitado");
    }
}
