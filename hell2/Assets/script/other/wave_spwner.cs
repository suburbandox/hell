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
        StartCoroutine(startnextwave(currentwaveindex));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator startnextwave(int index)
    {
        yield return new WaitForSeconds(timebtwwave);
        StartCoroutine(spawnwave(index));
    }

    IEnumerator spawnwave(int index)
    {
        currentwave = waves[index];
        for (int i = 0; i < currentwave.count; i++)
        {
            if (player == null)
            {
                yield break;
            }
            enemy randomenamy = currentwave.enemies[Random.Range(0, currentwave.enemies.Length)];
            Transform randomspot = spawnpoints[Random.Range(0, spawnpoints.Length)];
            Instantiate(randomenamy, randomspot.position, randomspot.rotation);
            yield return new WaitForSeconds(currentwave.timebtwspawn);
        }

    }
}
