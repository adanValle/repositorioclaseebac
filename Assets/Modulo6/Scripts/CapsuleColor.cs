using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleColor : MonoBehaviour
{
    public GameObject PrefabCapsule;
    public GameObject capsule;
    public Color color;

    // Start is called before the first frame update
    void Start()
    {
        capsule = Instantiate<GameObject>(PrefabCapsule);
        capsule.name = "Modulo6_capsule";
        color = new Color(255, 255, 255);
        capsule.GetComponent<MeshRenderer>().material.color = color;
        Vector3 pos;
        pos.x = 23;
        pos.y = 1;
        pos.z = 2;
        capsule.transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        color.r = Random.value;
        color.g = Random.value;
        color.b = Random.value;
        capsule.GetComponent<MeshRenderer>().material.color = color;
    }
}
