using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnAwake : MonoBehaviour
{
    public GameObject PrefabCube;

    private void Awake()
    {
        GameObject CubeOnAwake = Instantiate<GameObject>(PrefabCube);
        CubeOnAwake.name = "CubeOnAwake";
        Color color = new Color(Random.value, Random.value, Random.value);
        CubeOnAwake.GetComponent<MeshRenderer>().material.color = color;
        Vector3 position = new Vector3();
        position.x = -5;
        position.y = 1;
        position.z = -5;
        CubeOnAwake.transform.position = position;
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
