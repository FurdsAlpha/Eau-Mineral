﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joueur : Combattant
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        Attaque(Ennemie.collider.gameObject);
    }

    public void Attaque()
    {
        
    }
}
