using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnDisEn : MonoBehaviour
{
    public GameObject PrefabCube;
    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        cube = Instantiate<GameObject>(PrefabCube);
        cube.name = "Cube On Enable";
        Color color = new Color(255, 255, 255);
        cube.GetComponent<MeshRenderer>().material.color = color;
        Vector3 pos;
        pos.x = 22;
        pos.y = 1;
        pos.z = -1;
        cube.transform.position = pos;
    }

    private void OnDisable()
    {
        cube = Instantiate<GameObject>(PrefabCube);
        cube.name = "Cube On Disable";
        Color color = new Color(120, 120, 120);
        cube.GetComponent<MeshRenderer>().material.color = color;
        Vector3 pos;
        pos.x = 22;
        pos.y = 1;
        pos.z = -1;
        cube.transform.position = pos;
    }
}
