using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionDeVie : MonoBehaviour
{
    public float _heal = 20.0f;
    public static bool _popoHeal = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OnUtiliserConsommable();
    }

    public void OnUtiliserConsommable()
    {
        if( _popoHeal == true)
        {
            PlayerLife._life = PlayerLife._life + _heal;

            Destroy(this.gameObject);
        }
    }
}
