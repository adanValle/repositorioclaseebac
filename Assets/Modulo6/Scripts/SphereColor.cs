using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereColor : MonoBehaviour
{
    public GameObject PrefabSphere;
    public GameObject sphere;
    public Color color;

    // Start is called before the first frame update
    void Start()
    {
        sphere = Instantiate<GameObject>(PrefabSphere);
        sphere.name = "Modulo6_Sphere";
        color = new Color(255, 255, 255);
        sphere.GetComponent<MeshRenderer>().material.color = color;
        Vector3 pos;
        pos.x = 22;
        pos.y = 1;
        pos.z = -1;
        sphere.transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        color.r = Random.value; 
        color.g = Random.value; 
        color.b = Random.value;
        sphere.GetComponent<MeshRenderer>().material.color = color;
    }
}
