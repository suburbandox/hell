using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorpioai : MonoBehaviour
{

    public int dir;
    public float wander_speed;
    public float charge_speed;
    public bool move = true;
    public bool attack;
    public Animator ani;
    public int r;


    ///Transform p;

    // Start is called before the first frame update
    void Start()
    {
        //p = GameObject.FindGameObjectWithTag("Player").transform;
        ani = gameObject.GetComponent<Animator>();
        StartCoroutine(wat());

    }

    // Update is called once per frame
    void Update()
    {
        if (move)
        {
            transform.position += transform.right * wander_speed * Time.deltaTime;
        }
        /*
        if (attack)
        {
            move = false;
            StopCoroutine("wat");
            transform.position = Vector2.MoveTowards(transform.position, p.position, charge_speed * Time.deltaTime);
        }
        /*
        if (Vector2.Distance(transform.position,p.position) < 8)
        {
            attack = true;
        }
        */
    }
    
    IEnumerator wat()
    {
        ani.SetBool("still", false);
        move = true;
        yield return new WaitForSeconds(4);
        ani.SetBool("still", true);
        move = false;
        yield return new WaitForSeconds(2);
        dir = Random.Range(-15, 16);
        flip();
        //transform.rotation = Quaternion.Euler(0, 0, dir);
        StartCoroutine(wat());
    }
    void flip()
    {
        r = Random.Range(0, 2);
        if (r == 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, dir);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, dir);
        }
    }

}
