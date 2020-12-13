using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class gun : MonoBehaviour
{
    public int offset;
    public float starttimebtwshot;
    public GameObject projetile;
    public Transform shotpoint;
    public Rigidbody2D p;
    
    public float kick;

    public AudioSource sound;
    float timebtwshot;
    public Vector2 mousepos;

    void Start()
    {
        p = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        Vector3 dif = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float z = Mathf.Atan2(dif.y, dif.x) * Mathf.Rad2Deg;
        
        if (mousepos.x < 0)
        {
            transform.rotation = Quaternion.Euler(-180, 0, -z + offset);
        }

        if (mousepos.x > 0 )
        {
            transform.rotation = Quaternion.Euler(0, 0, z + offset);
        }

        if (timebtwshot <= 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(projetile, shotpoint.position, shotpoint.rotation);
                p.AddRelativeForce(transform.up * -kick);
                sound.Play();
                timebtwshot = starttimebtwshot;
            }
        }
        else
        {
            timebtwshot -= Time.deltaTime;
        }
    }
}