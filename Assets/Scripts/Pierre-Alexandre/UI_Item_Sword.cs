using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI_Item_Sword : MonoBehaviour
{
    public Sword sword;
    public Image image;
    // Start is called before the first frame update
    void Start()
    {
        image.sprite = sword.artwork;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
