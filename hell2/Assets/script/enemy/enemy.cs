using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class enemy : MonoBehaviour
{

    public GameObject blood;
    public int maxhealth = 100;
    public AudioSource cry;
    public death_sound d;
    public string n;
    int currentheaith;



    // Start is called before the first frame update
    void Start()
    {
        cry = gameObject.GetComponent<AudioSource>();
        d = GameObject.FindGameObjectWithTag("death").GetComponent<death_sound>();
        currentheaith = maxhealth;
    }
    public void takedamage(int damage)
    {
        currentheaith -= damage;
        cry.Play();

        if (currentheaith <= 0)
        {
            die();
        }
    }
    void die()
    {
        d.die(n);
        Instantiate(blood, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
