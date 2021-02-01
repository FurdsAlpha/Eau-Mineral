using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_Item_Arc : MonoBehaviour
{
    public Bow bow;
    public SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        sprite.sprite = bow.artwork;
    }
}
