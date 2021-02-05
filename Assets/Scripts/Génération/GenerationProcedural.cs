using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerationProcedural : MonoBehaviour
{
    [Header("Listes des salles")]
    public List<GameObject> _salleDroite;
    public List<GameObject> _salleGauche;
    public List<GameObject> _salleBasse;
    public List<GameObject> _salleHaute;

    [Header("Paramètres")]
    public static bool _spawnD = false;
    public static bool _spawnG = false;
    public static bool _spawnB = false;
    public static bool _spawnH = false;
    Vector2 _spawnPosition;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnD();
        SpawnG();
        SpawnB();
        SpawnH();
    }

    public void SpawnD()
    {
        if(_spawnD == true)
        {
            Debug.Log("Je fais spawn une salle");
            int randomNumberListD = Random.Range(0, _salleDroite.Count-1);
            Debug.Log(_salleDroite.Count-1);
            _spawnPosition = new Vector2(gameObject.transform.position.x,gameObject.transform.position.y);
            Instantiate(_salleDroite[randomNumberListD], _spawnPosition, Quaternion.identity);
            _spawnD = false;
        }
    }
    public void SpawnG()
    {
        if(_spawnG == true)
        {
            Debug.Log("Je fais spawn une salle");
            int randomNumberListG = Random.Range(0, _salleGauche.Count-1);
            _spawnPosition = new Vector2(gameObject.transform.position.x,gameObject.transform.position.y);
            Instantiate(_salleDroite[randomNumberListG], _spawnPosition, Quaternion.identity);
            _spawnG = false;
        }
    }
    public void SpawnB()
    {
        if(_spawnB == true)
        {
            Debug.Log("Je fais spawn une salle");
            int randomNumberListB = Random.Range(0, _salleBasse.Count-1);
            _spawnPosition = new Vector2(gameObject.transform.position.x,gameObject.transform.position.y);
            Instantiate(_salleDroite[randomNumberListB], _spawnPosition, Quaternion.identity);
            _spawnB = false;
        }
    }
    public void SpawnH()
    {
        if(_spawnH == true)
        {
            Debug.Log("Je fais spawn une salle");
            int randomNumberListH = Random.Range(0, _salleHaute.Count-1);
            _spawnPosition = new Vector2(gameObject.transform.position.x,gameObject.transform.position.y);
            Instantiate(_salleDroite[randomNumberListH], _spawnPosition, Quaternion.identity);
            _spawnH = false;
        }
    }
}
