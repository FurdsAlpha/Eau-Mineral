using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_Item : MonoBehaviour
{
    public Sword sword;
    public SpriteRenderer image;
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
