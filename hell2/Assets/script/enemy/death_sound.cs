using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class death_sound : MonoBehaviour
{
    public GameObject t;
    public Transform w;

    public AudioSource cry;
    public AudioClip pig_cry;
    public AudioClip crab_cry;
    public AudioClip scorp_cry;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            //Instantiate(t, w.position, Quaternion.identity, w);
        }
    }
    public void die(string name)
    {
        if (name == "pig")
        {
            cry.clip = pig_cry;
        }
        if (name == "crab")
        {
            cry.clip = crab_cry;

        }
        if (name == "scorp")
        {
            cry.clip = scorp_cry;

        }
        cry.Play();
    }
    /*
    public void piggy()
    {
        pig_cry.Play();
    }
    public void crabby()
    {
        crab_cry.Play();
    }
    public void scorpio()
    {
        scorp_cry.Play();
    }
    /*/
}
