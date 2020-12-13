using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ai : MonoBehaviour
{

    public int dir;
    public float wander_speed;
    public float charge_speed;
    public bool move = true;
    public bool attack;


    //Transform p;

    // Start is called before the first frame update
    void Start()
    {
        //p = GameObject.FindGameObjectWithTag("Player").transform;
        StartCoroutine(wat());

    }

    // Update is called once per frame
    void Update()
    {
        if (move)
        {
            transform.position += transform.right * wander_speed * Time.deltaTime;
        }
        if (attack)
        {
            move = false;
            StopCoroutine("wat");
            //transform.position = Vector2.MoveTowards(transform.position, p.position, charge_speed * Time.deltaTime);
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
        move = true;
        yield return new WaitForSeconds(7);
       
        move = false;
        yield return new WaitForSeconds(7);
        dir = Random.Range(0, 360);
        transform.rotation = Quaternion.Euler(0, 0, dir);
        StartCoroutine(wat());
    }
}
