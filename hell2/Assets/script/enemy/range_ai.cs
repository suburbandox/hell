using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class range_ai : MonoBehaviour
{

    public float sp;
    public float stop;
    public float retreat;
    public float time;
    public float time_between_shots;
    public GameObject bul;
    public Transform p;

    // Start is called before the first frame update
    void Start()
    {
        p = GameObject.FindGameObjectWithTag("Player").transform;
        time = time_between_shots;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, p.position) > stop)
        {
            transform.position = Vector2.MoveTowards(transform.position, p.position, sp * Time.deltaTime);
        }
        else if (Vector2.Distance(transform.position, p.position) < stop && Vector2.Distance(transform.position, p.position) > retreat)
        {
            transform.position = transform.position;
        }
        else if (Vector2.Distance(transform.position, p.position) < retreat)
        {
            transform.position = Vector2.MoveTowards(transform.position, p.position, -sp * Time.deltaTime);
        }

        if (time <= 0)
        {
            Instantiate(bul, transform.position, p.transform.rotation);
            time = time_between_shots;
        }
        else
        {
            time -= Time.deltaTime;
        }

    }
}
