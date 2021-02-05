using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interaction : MonoBehaviour
{
    [Header("Script Afillier")]
    public Inventaire inventaire;
    
    [Header("Intéraction")]
    public bool _onInteragir = false;
    //public bool _onInteragir = false;
    public float _interactionRadius;
    public LayerMask layerMask;

    [Header("Effets")]
    public static bool _haveKey = false;
    public static bool _ouverture = false;
    //Une fonction() pour changer l'arme dans l'ui et dans l'attaque existe dejat dans le Script_Attaque on la recupere pour pourvoir l'utiliser quand on interagie avec l'arme

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnInteragir()
    {
        Interagir();
    }

    public void Interagir()
    {
        Collider[] hitObjet = Physics.OverlapSphere(gameObject.transform.position, _interactionRadius, layerMask);
        foreach (Collider objet in hitObjet)
        {
            if (objet.tag == "EpeeSimple")
            {
                inventaire.armeEquiper = Arme.EpeeSimple;
                inventaire.ArmeEquiper();
            }
            if (objet.tag == "EpeeDouble")
            {
                inventaire.armeEquiper = Arme.EpeeDouble;
                inventaire.ArmeEquiper();
            }
            if (objet.tag == "ArcSimple")
            {
                inventaire.armeEquiper = Arme.ArcSimple;
                inventaire.ArmeEquiper();
            }
            if (objet.tag == "HealPotion")
            {
                inventaire.potionEquiper = Potion.HealPotion;
                inventaire.PotionEquiper();
            }
            if (objet.tag == "SpeedPotion")
            {
                inventaire.potionEquiper = Potion.VitessePotion;
                inventaire.PotionEquiper();
            }
            if (objet.tag == "BoostPotion")
            {
                inventaire.potionEquiper = Potion.BoostPotion;
                inventaire.PotionEquiper();
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
            if (objet.tag == "Clé")
            {
                Debug.Log("J'ai trouvé une clé");
                //La clé apparait dans l'inventaire
                _haveKey = true;
            }
            if (objet.tag == "Door")
            {
                Debug.Log("J'ai trouvé une porte");
                if (_haveKey == true)
                {
                    Debug.Log("J'ai ouvert la porte");
                    _ouverture = true;
                    _haveKey = false;
                }
            }
        }
    }
    private void OnDrawGizmosSelected()
    {
        if (this == null)
            return;
        Gizmos.DrawWireSphere(this.transform.position, _interactionRadius);
    }
}
