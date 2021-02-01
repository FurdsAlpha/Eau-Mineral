using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA_Gobelin : MonoBehaviour
{
    [Header("Personnages")]
    public Rigidbody2D _rigidbodyG;
    public GameObject _target;
    public Animator _gobelinAnimator;

    [Header("Paramètres")]
    public Vector2 _directionG;
    public static float _speedG = 3.0f;

    [Header("Déplacement")]
    public Transform[] _waypoints;
    public Transform _targetPoint;
    public int _destination = 0;

    /*[Header("TirDeRaycast")]
    public  Transform GoTo; // direction du raycast
    public Vector2 CurrentWaypoint;  // waypoint visé
    public GameObject RightPoint;   // Waypoint droit
    public GameObject LeftPoint;        // waypoint gauche
    float Range = 4.0f;  // longueur du rayon*/


    [Header("Combat")]
    public static bool _reperageG = false;
    public int _degatsG = 1;
    public float _rateAttackG = 0.5f;
    public float _distanceToAttackG =1.0f;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbodyG = GetComponent<Rigidbody2D>();
        _targetPoint = _waypoints[0];
        //GoTo = RightPoint.transform;
    }

    // Update is called once per frame
    void Update()
    {
        WayMove();
        GoToPLayer();
        _gobelinAnimator.SetFloat("HorizontalG", _directionG.x);
        _gobelinAnimator.SetFloat("VerticalG", _directionG.y);
    }

    public void WayMove()
    {
        if(_reperageG == false)
        {
            Vector2 _waypointsDirection = _targetPoint.position - gameObject.transform.position;
            _rigidbodyG.velocity = _waypointsDirection.normalized * _speedG;
            _directionG = _waypointsDirection;

            //SetRaycast();

            if(Vector2.Distance(_rigidbodyG.position, _targetPoint.position) < 0.1f) //La fonction fait changer la cible du Gobelin
            {                
                _destination = (_destination + 1) % _waypoints.Length;
                _targetPoint = _waypoints[_destination];
            }
        }
    }

    /*public void SetRaycast()
    {
        RaycastHit2D _hit = Physics2D.Raycast(transform.position, CurrentWaypoint, Range);// tire le raycast 
       
        if (GoTo.transform.position == RightPoint.transform.position)
        { Debug.DrawLine(transform.position, new Vector2(transform.position.x + Range, transform.position.y));
           
            if (Vector2.Distance(transform.position, GoTo.position) < 0.1f)
            {
                GoTo = LeftPoint.transform;
                CurrentWaypoint = Vector2.left;
            }
            if(_hit.collider.tag != null)
            {
                Debug.Log(_hit.collider.tag);
                //_reperageG = true;
            }
        }
        if (GoTo.transform.position == LeftPoint.transform.position)
        {
            Debug.DrawLine(transform.position, new Vector2(transform.position.x - Range, transform.position.y));
            if (Vector2.Distance(transform.position, GoTo.position) < 0.1f)
            {
                GoTo = RightPoint.transform;
                CurrentWaypoint = Vector2.right;
            }
            if(_hit.collider.tag != null)
            {
                Debug.Log(_hit.collider.tag);
                //_reperageG = true;
            }
        }
    }*/

    public void GoToPLayer()
    {
        if(_reperageG == true)
        {
            Vector2 _vectorPlayerTarget = _target.transform.position - gameObject.transform.position;

            if(_vectorPlayerTarget.magnitude > _distanceToAttackG)
            {
                _directionG = _vectorPlayerTarget;
                _rigidbodyG.velocity = _directionG * _speedG;
                _rateAttackG = 0;
            }
            else
            {
                _rigidbodyG.velocity = Vector2.zero;
                AttackS();
            }

            if(_vectorPlayerTarget == null)
        {
            _rigidbodyG.velocity = Vector2.zero;
        }
        }
    }

    public void AttackS()
    {
        _rateAttackG -= Time.deltaTime;

        if(_rateAttackG < 0)
        {
            PlayerLife._life = PlayerLife._life - _degatsG;
            _rateAttackG = 0.5f;
        }
    }
}
