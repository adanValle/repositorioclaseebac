using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnUpdate : MonoBehaviour
{
    public GameObject PrefabCube;
    public GameObject cube;
    public int numCubes;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cube = Instantiate<GameObject>(PrefabCube);
        cube.name = "Cube" + numCubes++;
        Color color = new Color(255, 255, 255);
        cube.GetComponent<MeshRenderer>().material.color = color;
        Vector3 pos;
        pos.x = 22;
        pos.y = 1;
        pos.z = -1;
        cube.transform.position = pos;
    }
}
