﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MegaCollider : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            IA_Gobelin._reperageG = true;
        }
    }
}
