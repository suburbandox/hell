using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{

    public Transform spawnpoint;
    public GameObject imp;
    public float spawnrate;



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("sp", spawnrate, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void sp()
    {

        Instantiate(imp, spawnpoint.position, Quaternion.identity);
    }
}
