using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Deplacement : MonoBehaviour
{
    [Header("Personnage")]
    public Rigidbody2D _rigidbody;
    public Animator _playerAnimator;

    [Header("Paramètres")]
    public Vector2 _direction = Vector2.zero;
    public static float _speed = 5.0f;


    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _rigidbody.velocity = _direction * _speed;
        _playerAnimator.SetFloat("Horizontal", _direction.x);
        _playerAnimator.SetFloat("Vertical", _direction.y);
    }

    public void OnMove(InputValue value)
    {
        Vector2 Mouvement = value.Get<Vector2>();
        _direction = new Vector2(Mouvement.x, Mouvement.y);
    }

    public void OnPause()
    {

    }
}
