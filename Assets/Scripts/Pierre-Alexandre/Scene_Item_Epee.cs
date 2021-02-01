using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_Item_Epee : MonoBehaviour
{
    public Sword epee;
    public SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        sprite.sprite = epee.artwork;
    }
}
