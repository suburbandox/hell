using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wave_spwner : MonoBehaviour
{
    [System.Serializable]
    public class wave
    {
        public enemy[] enemies;
        public int count;
        public float timebtwspawn;
    }

    public wave[] waves;
    public Transform[] spawnpoints;
    public float timebtwwave;

    wave currentwave;
    int currentwaveindex;
    Transform player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
