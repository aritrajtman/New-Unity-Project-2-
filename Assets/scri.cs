﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scri : MonoBehaviour
{
    public int edad1;
    public int altura;
    // Start is called before the first frame update
    void Start()
    {
        if (altura < 1.2)
        {
            Debug.Log("no podes pasar");
        }
        else if (edad1 < 13)
        {
            Debug.Log("no podes pasar");
        }
        else
        {
            Debug.Log("podes pasar");
        }
        if (edad1< 1)
        {
            Debug.Log("error");
        }
        else if (altura < 0)
        {
            Debug.Log("error");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
