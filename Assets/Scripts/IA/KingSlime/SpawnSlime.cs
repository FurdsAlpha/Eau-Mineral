using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSlime : MonoBehaviour
{
    public GameObject slime;
    public float _timeslime = 0f;

    [Header("Positions")]
    float xSpawn;
    float ySpawn;
    Vector2 spawnPosition;

    void Update()
    {
        Spawn();
    }

    public void Spawn()
    {
        _timeslime += Time.deltaTime;

        if (_timeslime > 30)
        {
            xSpawn = transform.position.x;
            ySpawn = transform.position.y;
            spawnPosition = new Vector2(xSpawn, ySpawn);

            Instantiate(slime, spawnPosition, Quaternion.identity);
            _timeslime = 0f;
        }
    }
}
