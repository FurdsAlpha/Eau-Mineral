using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionDeBoost : MonoBehaviour
{/*
    public float _boost = 2.0f;
    public static bool _popoBoost = false;
    public float _rateBoost = 30.0f;
    public bool _coolDown = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OnUtiliserConsommable();
        CoolDown();
    }

    public void OnUtiliserConsommable()
    {
        if( _popoBoost == true)
        {
            Scrip_Attaque._degat = Scrip_Attaque._degat * _boost;
            _coolDown = true;
        }
    }

    public void CoolDown()
    {
        if(_coolDown == true)
        {
            _rateBoost -= Time.deltaTime;

            if(_rateBoost <= 0)
            {
                Scrip_Attaque._degat = Scrip_Attaque._degat/_boost;
                _rateBoost = 30.0f;
                _popoBoost = false;
                _coolDown = false;
                Destroy(this.gameObject);        
            }
        }
    }*/
}
