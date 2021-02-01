using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA_Slime : MonoBehaviour
{
    [Header("Personnages")]
    public Rigidbody2D _rigidbodyS;
    public GameObject _target;
    public Animator _slimeAnimator;

    [Header("Paramètres")]
    public static Vector2 _directionS;
    public static float _speedS = 1.0f;

    [Header("Combat")]
    public int _degatsS = 2;
    public float _rateAttackS = 2.0f;

    public float _distanceToAttackS =1.0f;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbodyS = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        GoToPLayer();
        _slimeAnimator.SetFloat("HorizontalS", _directionS.x);
        _slimeAnimator.SetFloat("VerticalS", _directionS.y);
    }

    public void GoToPLayer()
    {
        Vector2 _vectorPlayerTarget = _target.transform.position - gameObject.transform.position;

        if(_vectorPlayerTarget.magnitude > _distanceToAttackS)
        {
            _directionS = _vectorPlayerTarget;
            _rigidbodyS.velocity = _directionS * _speedS;
            _rateAttackS = 0;
        }
        else
        {
            _rigidbodyS.velocity = Vector2.zero;
            AttackS();
        }

        if(_vectorPlayerTarget == null)
        {
            _rigidbodyS.velocity = Vector2.zero;
        }
    }

    public void AttackS()
    {
        _rateAttackS -= Time.deltaTime;

        if(_rateAttackS < 0)
        {
            PlayerLife._life = PlayerLife._life - _degatsS;
            _rateAttackS = 2.0f;
        }
    }
}
