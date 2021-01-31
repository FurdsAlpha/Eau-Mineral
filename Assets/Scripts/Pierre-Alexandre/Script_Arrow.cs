using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Arrow : MonoBehaviour
{
    public float speed;
    public Vector3 pos;
    public GameObject attakPoint;
    public Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        dir = attakPoint.transform.position;
        pos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        pos += dir * speed * Time.deltaTime;
        this.transform.position = new Vector2(pos.x, pos.y);
    }
}
