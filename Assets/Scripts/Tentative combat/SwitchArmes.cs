using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchArmes : MonoBehaviour
{
    public GameObject[] Weapon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Sword()
    {
        Weapon[0].SetActive(true);
        Weapon[1].SetActive(false);
    }

    public void Bow()
    {
        Weapon[0].SetActive(false);
        Weapon[1].SetActive(true);
    }
}
