using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ren : MonoBehaviour
{

    public Transform p;
    public SpriteRenderer s;

    // Start is called before the first frame update
    void Start()
    {
        p = GameObject.FindGameObjectWithTag("Player").transform;
        s = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (p.position.y > transform.position.y)
        {
            s.color = new Color(255, 255, 255, 0.5f);
            s.sortingOrder = 100;
        }
        else
        {
            s.color = new Color(255, 255, 255, 1f);
            s.sortingOrder = -100;
        }
    }

    
}
