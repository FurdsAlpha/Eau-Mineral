﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interaction : MonoBehaviour
{
    public bool _onInteragir = false;
    public float _interactionRadius = 1f;
    public LayerMask layerMask;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        if(_onInteragir == true)
        {
            _onInteragir = false;
            Interagir();
        }
    }

    public void Interagir()
    {
        Collider [] hitColliders = Physics.OverlapSphere(gameObject.transform.position, _interactionRadius,layerMask);
        int i = 0;

        while(i <hitColliders.Length)
        {
            Debug.Log("Hit:" + hitColliders [i] .tag + i) ;

            /*if(hitColliders [i].tag=="PotionSoins")
            {

            }*/

            i++;
        }
    }

    public void OnInteragir()
    {
        _onInteragir = true;
    }
}
