using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public List<GameObject> _keyConditionKills;
    public GameObject _key;

    // Start is called before the first frame update
    void Start()
    {
        _key.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(_keyConditionKills == null)
        {
            _key.SetActive(true);
        }
    }
}
