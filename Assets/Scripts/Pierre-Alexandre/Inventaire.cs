using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Enumeration des objet existant part categorie
public enum Potion { none, HealPotion, VitessePotion, BoostPotion }
public enum Arme { none, EpeeSimple, EpeeDouble, ArcSimple }
public enum Pouvoir { none, Poison, Flamme, Gel }
public class Inventaire : MonoBehaviour
{
    [Header("Quel Objet Aficher ?")]
    public Potion potionEquiper;
    public Arme armeEquiper;
    public Pouvoir pouvoirEquiper;

    [Header("Stockage Objet dans l'UI")]
    public GameObject[] UI_Potion;//0-vitesse 1-heal 2-boost
    public GameObject[] UI_Armes;//0-epeeSimple 1-epeeDouble 2-arcSimple
    public GameObject[] UI_Pouvoir;//0-Gel 1-Flamme 2-Poison

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PotionEquiper();
        ArmeEquiper();
        PouvoirEquiper();
    }
    public void PotionEquiper()
    {
        if(potionEquiper.ToString() == "none")
        {
            UI_Potion[0].SetActive(false);
            UI_Potion[1].SetActive(false);
            UI_Potion[2].SetActive(false);
        }
        if(potionEquiper.ToString() == "VitessePotion")
        {
            UI_Potion[0].SetActive(true);
            UI_Potion[1].SetActive(false);
            UI_Potion[2].SetActive(false);
        }
        if(potionEquiper.ToString() == "HealPotion")
        {
            UI_Potion[0].SetActive(false);
            UI_Potion[1].SetActive(true);
            UI_Potion[2].SetActive(false);
        }
        if(potionEquiper.ToString() == "BoostPotion")
        {
            UI_Potion[0].SetActive(false);
            UI_Potion[1].SetActive(false);
            UI_Potion[2].SetActive(true);
        }
    }
    public void ArmeEquiper()
    {
        if (armeEquiper.ToString() == "none")
        {
            UI_Armes[0].SetActive(false);
            UI_Armes[1].SetActive(false);
            UI_Armes[2].SetActive(false);
        }
        if (armeEquiper.ToString() == "EpeeSimple")
        {
            UI_Armes[0].SetActive(true);
            UI_Armes[1].SetActive(false);
            UI_Armes[2].SetActive(false);
        }
        if (armeEquiper.ToString() == "EpeeDouble")
        {
            UI_Armes[0].SetActive(false);
            UI_Armes[1].SetActive(true);
            UI_Armes[2].SetActive(false);
        }
        if (armeEquiper.ToString() == "ArcSimple")
        {
            UI_Armes[0].SetActive(false);
            UI_Armes[1].SetActive(false);
            UI_Armes[2].SetActive(true);
        }
    }
    public void PouvoirEquiper()
    {
        if (pouvoirEquiper.ToString() == "none")
        {
            UI_Pouvoir[0].SetActive(false);
            UI_Pouvoir[1].SetActive(false);
            UI_Pouvoir[2].SetActive(false);
        }
        if (pouvoirEquiper.ToString() == "Gel")
        {
            UI_Pouvoir[0].SetActive(true);
            UI_Pouvoir[1].SetActive(false);
            UI_Pouvoir[2].SetActive(false);
        }
        if (pouvoirEquiper.ToString() == "Flamme")
        {
            UI_Pouvoir[0].SetActive(false);
            UI_Pouvoir[1].SetActive(true);
            UI_Pouvoir[2].SetActive(false);
        }
        if (pouvoirEquiper.ToString() == "Poison")
        {
            UI_Pouvoir[0].SetActive(false);
            UI_Pouvoir[1].SetActive(false);
            UI_Pouvoir[2].SetActive(true);
        }
    }
}