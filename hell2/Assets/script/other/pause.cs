﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{

    public bool sw;
    public GameObject pas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            sw = !sw; 
        }
        if (sw)
        {
            pas.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            pas.SetActive(false);

            Time.timeScale = 1;
        }
    }
}
