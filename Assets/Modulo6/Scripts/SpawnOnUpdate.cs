using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnUpdate : MonoBehaviour
{
    public GameObject PrefabCube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject CubeOnUpdate = Instantiate<GameObject>(PrefabCube);
        CubeOnUpdate.name = "CubeOnUpdate";
        Color color = new Color(Random.value, Random.value, Random.value);
        CubeOnUpdate.GetComponent<MeshRenderer>().material.color = color;
        Vector3 position = new Vector3();
        position.x = 0;
        position.y = 1;
        position.z = -5;
        CubeOnUpdate.transform.position = position;
    }
}
