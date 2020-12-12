using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class audio : MonoBehaviour
{


    public AudioMixer doom;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Lowpass()
    {
        if (doom)
        {

            
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;

        }
    }
    public void setmusic(float m)
    {
        doom.SetFloat("music", m);
    }
    public void setsfx(float m)
    {
        doom.SetFloat("sfx", m);
    }
    public void setmaster(float m)
    {
        doom.SetFloat("master", m);
    }
}
