using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnAwake : MonoBehaviour
{
    public GameObject PrefabCube;

    private void Awake()
    {
        GameObject cube = Instantiate<GameObject>(PrefabCube);
        cube.name = "Modulo6_Cube";
        Color color = new Color(Random.value, Random.value, Random.value);
        cube.GetComponent<MeshRenderer>().material.color = color;
        Vector3 pos;
        pos.x = 14;
        pos.y = 1;
        pos.z = 4;
        cube.transform.position = pos;
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
