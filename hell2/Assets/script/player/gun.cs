using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public int offset;
    public float starttimebtwshot;
    public GameObject projetile;
    public Transform shotpoint;
    public float timebtwshot;

    void Update()
    {
        Vector2 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
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
                timebtwshot = starttimebtwshot;
            }
        }
        else
        {
            timebtwshot -= Time.deltaTime;
        }

    }
}