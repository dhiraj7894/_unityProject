﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy2 : MonoBehaviour
{
    private int _destry = 3;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(_destry > 0)
        {
            _destry--;
            Debug.Log(_destry);
        }
        else if (_destry == 0)
        {
            Destroy(gameObject);
            FindObjectOfType<GameManagerGame>().Out();
        }

    }
}
