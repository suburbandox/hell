using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rot : MonoBehaviour
{
    public Vector2 mousepos;
    public bool flip;

    void Update()
    {
        mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        if (mousepos.x < 0 && !flip)
        {
            flips();
        }
        
        if (mousepos.x > 0 && flip)
        {
            flips();
        }
    }
    void flips()
    {
        transform.Rotate(0, 180, 0);
        flip = !flip;
    }
}
