using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interaction : MonoBehaviour
{
    //public bool _onInteragir = false;
    public float _interactionRadius = 1f;
    public LayerMask layerMask;

    public Scrip_Attaque interactionArme;
    //Une fonction() pour changer l'arme dans l'ui et dans l'attaque existe dejat dans le Script_Attaque on la recupere pour pourvoir l'utiliser quand on interagie avec l'arme

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Interagir()
    {
        Collider[] hitObjet = Physics.OverlapSphere(gameObject.transform.position, _interactionRadius, layerMask);
        foreach (Collider objet in hitObjet)
        {
            if (objet.tag == "EpeeSimple")
            {
                interactionArme.EpeeSimple();
            }
            if (objet.tag == "EpeeDouble")
            {
                interactionArme.EpeeDouble();
            }
            if (objet.tag == "ArcSimple")
            {
                interactionArme.ArcSimple();
            }
            if (objet.tag == "HealPotion")
            {
                Debug.Log("J'ai trouvé une potion de heal");
                PotionDeVie._popoHeal = true;
            }
            if (objet.tag == "SpeedPotion")
            {
                Debug.Log("J'ai trouvé une potion de speed");
                PotionDeVitesse._popoSpeed = true;
            }
            if (objet.tag == "BoostPotion")
            {
                Debug.Log("J'ai trouvé une potion de boost");
                PotionDeBoost._popoBoost = true;
            }
            if (objet.tag == "Cle")
            {
                Debug.Log("J'ai trouvé une clé");
                //La clé apparait dans l'inventaire
                //Variable "j'ai la clé" devient vrai
            }
            if (objet.tag == "Door")
            {
                Debug.Log("J'ai trouvé une porte");
                //if(Variable "j'ai la clé est vraie)
                {
                    //La porte s'ouvre
                    //La clé se détruit
                }
            }

            Collider [] hitColliders = Physics.OverlapSphere(gameObject.transform.position, _interactionRadius,layerMask);
            int i = 0;
            while (i <hitColliders.Length)
            {
                Debug.Log("Hit:" + hitColliders [i] .tag + i) ;

                if(hitColliders [i].tag=="HealPotion")
                {
                    Debug.Log("J'ai trouvé une potion de heal");
                    PotionDeVie._popoHeal = true;
                }
                if(hitColliders [i].tag=="SpeedPotion")
                {
                    Debug.Log("J'ai trouvé une potion de speed");
                    PotionDeVitesse._popoSpeed = true;
                }
                if(hitColliders [i].tag=="BoostPotion")
                {
                    Debug.Log("J'ai trouvé une potion de boost");
                    PotionDeBoost._popoBoost = true;
                }
                if(hitColliders [i].tag=="Cle")
                {
                    Debug.Log("J'ai trouvé une clé");
                    //La clé apparait dans l'inventaire
                    //Variable "j'ai la clé" devient vrai
                }
                if(hitColliders [i].tag=="Door")
                {
                    Debug.Log("J'ai trouvé une porte");
                    //if(Variable "j'ai la clé est vraie)
                    {
                        //La porte s'ouvre
                        //La clé se détruit
                    }
                }
                if (hitColliders[i].tag == "EpeeSimple")
                {
                    interactionArme.EpeeSimple();
                }
                if (hitColliders[i].tag == "EpeeDouble")
                {
                    interactionArme.EpeeDouble();
                }
                if (hitColliders[i].tag == "ArcSimple")
                {
                    interactionArme.ArcSimple();
                }

                i++;
            }
        }
    }

    public void OnInteragir()
    {
        Interagir();
    }
}
