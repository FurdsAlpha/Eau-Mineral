using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpening : MonoBehaviour
{
    public GameObject _doorClose;
    public GameObject _doorOpen;
    public GameObject _doorCollider;

    // Start is called before the first frame update
    void Start()
    {
        _doorClose.SetActive(true);
        _doorOpen.SetActive(false);
        _doorCollider.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(Interaction._ouverture == true)
        {
            _doorClose.SetActive(false);
            _doorOpen.SetActive(true);
            _doorCollider.SetActive(false);
        }
    }
}
