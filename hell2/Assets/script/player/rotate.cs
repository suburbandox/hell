using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
   
    public Vector2 mousepos;
    public float sp = 5;

    void Update()
    {
        mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angele = Mathf.Atan2(mousepos.y, mousepos.x) * Mathf.Rad2Deg - 90;
        Quaternion r = Quaternion.AngleAxis(angele, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, r, Time.deltaTime * sp);
    }
}
