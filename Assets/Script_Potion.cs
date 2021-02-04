using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Potion : MonoBehaviour
{
    [Header("Script Afillier")]
    public Inventaire inventaire;
    public Scrip_Attaque _Attaque;
    public Deplacement deplacement;

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
        }
        
    }
    public void OnUtiliserConsommable()
    {
        if (inventaire.potionEquiper == Potion.BoostPotion)
        {
            PotionDeBoost();
        }
        if (inventaire.potionEquiper == Potion.BoostPotion)
        {
            PotionDeVitesse();
        }
        if (inventaire.potionEquiper == Potion.BoostPotion)
        {
            PotionDeVie();
        }
    }

    public void PotionDeVitesse()
    {
        Deplacement._speed += 1 * _speeding;
        inventaire.potionEquiper = Potion.none;
    }
    public void PotionDeBoost()
    {
        _Attaque._degat += 1 * _boost;
        inventaire.potionEquiper = Potion.none;
    }
    public void PotionDeVie()
    {
        PlayerLife._life = PlayerLife._life + _heal;
        inventaire.potionEquiper = Potion.none;
    }
}
