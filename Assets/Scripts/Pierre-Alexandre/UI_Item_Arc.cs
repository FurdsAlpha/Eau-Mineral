using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Item_Arc : MonoBehaviour
{
    public Bow bow;
    public Image image;
    // Start is called before the first frame update
    void Start()
    {
        image.sprite = bow.artwork;

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
