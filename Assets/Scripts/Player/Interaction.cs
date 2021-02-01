using System.Collections;
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

            if(hitColliders [i].tag=="HealPotion")
            {
                PotionDeVie._popoHeal = true;
            }
            if(hitColliders [i].tag=="SpeedPotion")
            {
                PotionDeVitesse._popoSpeed = true;
            }
            if(hitColliders [i].tag=="BoostPotion")
            {
                PotionDeBoost._popoBoost = true;
            }
            if(hitColliders [i].tag=="Cle")
            {
                //La clé apparait dans l'inventaire
                //Variable "j'ai la clé" devient vrai
            }
            if(hitColliders [i].tag=="Door")
            {
                //if(Variable "j'ai la clé est vraie)
                {
                    //La porte s'ouvre
                    //La clé se détruit
                }
            }

            i++;
        }
    }

    public void OnInteragir()
    {
        _onInteragir = true;
    }
}
