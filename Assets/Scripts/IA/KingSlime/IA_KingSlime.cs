using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA_KingSlime : MonoBehaviour
{
    [Header("Personnages")]
    public Rigidbody2D _rigidbodyKS;
    public GameObject _target;
    public Animator _slimeKingAnimator;

    [Header("Paramètres")]
    public Vector2 _directionKS;
    public float _speedKS = 0.5f;

    [Header("Combat")]
    public int _degatsKS = 10;
    public float _rateAttackKS = 3.0f;
    public float _distanceToAttackS =1.0f;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbodyKS = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        GoToPLayer();
        _slimeKingAnimator.SetFloat("HorizontalKS", _directionKS.x);
        _slimeKingAnimator.SetFloat("VerticalKS", _directionKS.y);
    }

    public void GoToPLayer()
    {
        Vector2 _vectorPlayerTarget = _target.transform.position - gameObject.transform.position;

        if(_vectorPlayerTarget.magnitude > _distanceToAttackS)
        {
            _directionKS = _vectorPlayerTarget;
            _rigidbodyKS.velocity = _directionKS * _speedKS;
            _rateAttackKS = 0;
        }
        else
        {
            _rigidbodyKS.velocity = Vector2.zero;
            AttackS();
        }

        if(_vectorPlayerTarget == null)
        {
            _rigidbodyKS.velocity = Vector2.zero;
        }
    }

    public void AttackS()
    {
        _rateAttackKS -= Time.deltaTime;

        if(_rateAttackKS < 0)
        {
            PlayerLife._life = PlayerLife._life - _degatsKS;
            _rateAttackKS = 2.0f;
        }
    }
}
