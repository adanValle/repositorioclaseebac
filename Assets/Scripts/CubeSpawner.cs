using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject PrefabCube;
    public List<GameObject> listCube;
    public float scaleFactor;
    public int numCubes;

    // Start is called before the first frame update
    void Start()
    {
        listCube = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        numCubes++;
        GameObject temp = Instantiate<GameObject>(PrefabCube);
        temp.name = "Cube" + numCubes;
        Color color = new Color(Random.value, Random.value, Random.value);
        temp.GetComponent<MeshRenderer>().material.color = color;
        temp.transform.position = Random.insideUnitSphere;

        listCube.Add(temp);
        List<GameObject> deleteObjects = new List<GameObject>();

        foreach (GameObject obj in listCube)
        {
            float scale = obj.transform.localScale.x;
            scale *= scaleFactor;
            obj.transform.localScale = Vector3.one * scale;

            if (scale <= 0.1)
            {
                deleteObjects.Add(obj);
            }
        }

        foreach (GameObject obj in deleteObjects)
        {
            listCube.Remove(obj);
            Destroy(obj);
        }
    }
}
