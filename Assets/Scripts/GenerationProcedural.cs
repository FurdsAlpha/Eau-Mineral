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
    public bool _spawnD = false;
    public bool _spawnG = false;
    public bool _spawnB = false;
    public bool _spawnH = false;
    float _xSpawn;
    float _ySpawn;
    Vector3 _spawnPosition;


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
            int randomNumberListD = Random.Range(0, _salleDroite.Count);
            //_spawnPosition = new Vector2(_xSpawn, _ySpawn);
            //Instantiate(_salleDroite[randomNumberListD], _spawnPosition, Quaternion.identity);
            _spawnD = false;
        }
    }
    public void SpawnG()
    {
        if(_spawnG == true)
        {
            int randomNumberListG = Random.Range(0, _salleGauche.Count);
            //_spawnPosition = new Vector2(_xSpawn, _ySpawn);
            //Instantiate(_salleGauche[randomNumberListG], _spawnPosition, Quaternion.identity);
            _spawnG = false;
        }
    }
    public void SpawnB()
    {
        if(_spawnB == true)
        {
            int randomNumberListB = Random.Range(0, _salleBasse.Count);
            //_spawnPosition = new Vector2(_xSpawn, _ySpawn);
            //Instantiate(_salleBasse[randomNumberListB], _spawnPosition, Quaternion.identity);
            _spawnB = false;
        }
    }
    public void SpawnH()
    {
        if(_spawnH == true)
        {
            int randomNumberListH = Random.Range(0, _salleHaute.Count);
            //_spawnPosition = new Vector2(_xSpawn, _ySpawn);
            //Instantiate(_salleHaute[randomNumberListH], _spawnPosition, Quaternion.identity);
            _spawnH = false;
        }
    }
    /*public void Spawn()
    {
        if (_spawnD == true)
        {
            xSpawn = Random.Range(0f, 9f);
            if (Random.value < 0.5f)
            {
                xSpawn = -xSpawn;
            }

            ySpawn = Random.Range(0f, 9f);
            if (Random.value < 0.5f)
            {
                ySpawn = -ySpawn;
            }

            int randomNumberListBaseFood = Random.Range(0, basicFood.Count);
            spawnPosition = new Vector2(xSpawn, ySpawn);
            Instantiate(basicFood[randomNumberListBaseFood], spawnPosition, Quaternion.identity);
            timer = 0f;
        }
    }*/
}
