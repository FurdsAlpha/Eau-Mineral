using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Potion : MonoBehaviour
{
    [Header("Script Afillier")]
    public Inventaire inventaire;
    public Scrip_Attaque _Attaque;
    public Deplacement deplacement;

    [Header("Effet activer")]
    public GameObject effetDeSoin;
    public GameObject effetDeForce;
    public GameObject effetDeVitesse;

    [Header("Potion De Vitesse Setings")]
    public float _speeding = 2.0f;
    public float _rateSpeed = 30.0f;
    public float cooldown;
    public bool _cooldown;

    [Header("Poition De Puissance Setings")]
    public float _boost = 2.0f;
    public float _rateBoost = 30.0f;

    [Header("Potion De Vie Settings")]
    public float _heal = 20.0f;

    // Update is called once per frame
    void Update()
    {
        cooldown -= 1 * Time.deltaTime;
        if(cooldown < 0)
        {
            Deplacement._speed = 5;
            inventaire.ArmeEquiper();
            effetDeForce.SetActive(false);
            effetDeSoin.SetActive(false);
            effetDeVitesse.SetActive(false);
        }
        
    }
    public void OnUtiliserConsommable()
    {
        Debug.Log("consommable utilisé");
        if (inventaire.potionEquiper == Potion.BoostPotion)
        {
            PotionDeBoost();
            inventaire.potionEquiper = Potion.none;
        }
        if (inventaire.potionEquiper == Potion.VitessePotion)
        {
            PotionDeVitesse();
            inventaire.potionEquiper = Potion.none;
        }
        if (inventaire.potionEquiper == Potion.HealPotion)
        {
            PotionDeVie();
            inventaire.potionEquiper = Potion.none;
        }
        inventaire.PotionEquiper();
    }

    public void PotionDeVitesse()
    {
        cooldown = _rateSpeed;
        effetDeVitesse.SetActive(true);
        Deplacement._speed = Deplacement._speed * _speeding;
    }
    public void PotionDeBoost()
    {
        cooldown = _rateBoost;
        effetDeForce.SetActive(true);
        _Attaque._degat = _Attaque._degat * _boost;
    }
    public void PotionDeVie()
    {
        cooldown = 5;
        effetDeSoin.SetActive(true);
        PlayerLife._life = PlayerLife._life + _heal;
    }
}
