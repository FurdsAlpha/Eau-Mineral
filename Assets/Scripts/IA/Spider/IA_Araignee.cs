using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA_Araignee : MonoBehaviour
{
    [Header("Personnages")]
    public Rigidbody2D _rigidbodySP;
    public GameObject _target;
    public Animator _spiderAnimator;

    [Header("Paramètres")]
    public Vector2 _directionSP;
    public float _speedSP = 1.0f;

    [Header("Combat")]
    public static bool _reperageSP = false;
    public int _degatsSP = 5;
    public float _rateAttackSP = 3.0f;
    public float _distanceToAttackSP =1.0f;

    [Header("Déplacement")]
    public float _timeToChange = 3.0f;
    public float _timer = 3.0f;

    [Header("Spawn Position")]
    float xSpawn;
    float ySpawn;
    Vector3 spawnPosition;

    [Header("Paramètres du Spawn")]
    public GameObject _web;
    public float spawnRate = 10.0f;
    public float timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbodySP = GetComponent<Rigidbody2D>();
        _timer += Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        RandomMove();
        WebSpawn();
        GoToPLayer();
        _spiderAnimator.SetFloat("HorizontalSP", _directionSP.x);
        _spiderAnimator.SetFloat("VerticalSP", _directionSP.y);
    }

    public void RandomMove()
    {        
        _timer += Time.deltaTime;
        if(_timer > _timeToChange)
        {
            _directionSP = new Vector2(Random.Range(-1.0f,1.0f), Random.Range(-1.0f,1.0f)).normalized;
            _rigidbodySP.velocity = _directionSP * _speedSP;

            _timer = 0.0f;
        }
    }
    public void WebSpawn()
    {
        timer += Time.deltaTime;
        if (timer > spawnRate)
        {
            spawnPosition = _rigidbodySP.position;
            Instantiate(_web, spawnPosition, Quaternion.identity);
            timer = 0f;
        }
    }

    public void GoToPLayer()
    {
        if(_reperageSP == true)
        {
            Vector2 _vectorPlayerTarget = _target.transform.position - gameObject.transform.position;

            if(_vectorPlayerTarget.magnitude > _distanceToAttackSP)
            {
                _directionSP = _vectorPlayerTarget;
                _rigidbodySP.velocity = _directionSP * _speedSP;
                _rateAttackSP = 0;
            }
            else
            {
                _rigidbodySP.velocity = Vector2.zero;
                AttackS();
            }

            if(_vectorPlayerTarget == null)
        {
            _rigidbodySP.velocity = Vector2.zero;
        }
        }
    }

    public void AttackS()
    {
        _rateAttackSP -= Time.deltaTime;

        if(_rateAttackSP < 0)
        {
            PlayerLife._life = PlayerLife._life - _degatsSP;
            _rateAttackSP = 3.0f;
        }
    }
}
