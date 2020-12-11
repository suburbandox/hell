using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class swich : MonoBehaviour
{
    public int pick;

    void Start()
    {
        choose();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if (pick >= transform.childCount - 1)
                pick = 0;
            else
                pick++;
            choose();
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (pick <= 0)
                pick = transform.childCount - 1;
            else
                pick--;
            choose();
        }
    }
    void choose()
    {
        int i = 0;
        foreach (Transform weapon in transform)
        {
            if (i == pick)
            {
                weapon.gameObject.SetActive(true);
                Debug.Log(weapon);
            }
            else
                weapon.gameObject.SetActive(false);
            i++;
        }
    }
}

