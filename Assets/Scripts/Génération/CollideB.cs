using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideB : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Le player vient du bas");
            GenerationProcedural._spawnB = true;
        }
    }
}
