﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JourneyLight : MonoBehaviour{
    public Material red;
    public Material white;
    public float shininessWhite;
    public float shininessRed;

    void Start()
    {
      
    }

    void Update()
    {
        white.SetFloat("_Glow", shininessWhite);
        red.SetFloat("_Glow", shininessRed);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (shininessWhite < 3)
            {
                {
                    shininessWhite += 2 * Time.deltaTime;
                }
            }
        }

        if (Input.GetKey(KeyCode.W))
        {
            if (shininessRed < 3)
            {
                {
                    shininessRed += 2 * Time.deltaTime;
                }
            }
        }

        if (Input.GetKey(KeyCode.S))
        {
            if (shininessRed > 0.1)
            {
                shininessRed -= 2 * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (shininessWhite > 0.1)
            {
                shininessWhite -= 2 * Time.deltaTime;
            }
        }



    }
}

