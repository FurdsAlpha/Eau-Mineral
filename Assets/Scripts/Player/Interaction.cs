using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interaction : MonoBehaviour
{
    [Header("Intéraction")]
    public bool _onInteragir = false;
    public float _interactionRadius = 1f;
    public LayerMask layerMask;

    [Header("Effets")]
    public static bool _haveKey = false;
    public static bool _ouverture = false;

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
            if(hitColliders [i].tag=="Clé")
            {
                Debug.Log("J'ai trouvé une clé");
                //La clé apparait dans l'inventaire
                _haveKey = true;
            }
            if(hitColliders [i].tag=="Door")
            {
                Debug.Log("J'ai trouvé une porte");
                if(_haveKey == true)
                {
                    Debug.Log("J'ai ouvert la porte");
                    _ouverture = true;
                    _haveKey = false;
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
