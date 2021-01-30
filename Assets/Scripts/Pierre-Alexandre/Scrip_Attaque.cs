using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrip_Attaque : MonoBehaviour
{
    public GameObject[] Weapon;
    public bool melee;
    public int _degats;
    // Start is called before the first frame update
    void Start()
    {
        Sword();
    }

    public void Sword()
    {
        Weapon[0].SetActive(true);
        Weapon[1].SetActive(false);
        melee = true;
    }

    public void Bow()
    {
        Weapon[0].SetActive(false);
        Weapon[1].SetActive(true);
    }

    public void OnAttak()
    {
        Attaque();
    }

    public void Attaque()
    {
        if (melee)
        {
            Weapon[0].GetComponent<Script_Epee>().Melee(); Debug.Log("commande melee envoyer");
        }

        if (melee == false)
        {
            Weapon[0].GetComponent<Script_Bow>().Shoot(); Debug.Log("commande shoot envoyer");
        }


    }
}
