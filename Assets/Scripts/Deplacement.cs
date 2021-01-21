using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Deplacement : MonoBehaviour
{
    [Header("Personnage")]
    public Rigidbody2D _rigidbody;

    [Header("Paramètres")]
    public Vector2 _direction = Vector2.zero;
    public float _speed;


    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _rigidbody.velocity = _direction * _speed;
    }

    public void OnMove(InputValue value)
    {
        Vector2 Mouvement = value.Get<Vector2>();
        _direction = new Vector2(Mouvement.x, Mouvement.y);
    }
}
