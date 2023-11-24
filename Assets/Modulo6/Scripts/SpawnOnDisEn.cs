using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnDisEn : MonoBehaviour
{
    public GameObject PrefabCube;
    public List<GameObject> listCube;
    public int numCubes;

    private void CreateCube(string method)
    {
        GameObject CubeOnDisEn = Instantiate<GameObject>(PrefabCube);
        CubeOnDisEn.name = "CubeOn" + method + numCubes++;
        Color color = new Color(Random.value, Random.value, Random.value);
        CubeOnDisEn.GetComponent<MeshRenderer>().material.color = color;
        Vector3 position = new Vector3();
        position.x = 5;
        position.y = 5;
        position.z = -5;
        CubeOnDisEn.transform.position = position;

        listCube.Add(CubeOnDisEn);
    }

    // Start is called before the first frame update
    void Start()
    {
        listCube = new List<GameObject>();
        numCubes = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        CreateCube("Enable");
    }

    private void OnDisable()
    {
        CreateCube("Disable");
    }
}
