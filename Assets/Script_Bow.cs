using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Bow : MonoBehaviour
{
    public GameObject arrow;
    public Transform arrowSpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("le script est bien dans la scene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnAttak()
    {
        Shoot();
        Debug.Log("OnAttak éffectué");
    }
    public void Shoot()
    {
        Instantiate(arrow, new Vector3(arrowSpawnPoint.position.x, arrowSpawnPoint.position.y, arrowSpawnPoint.position.z), Quaternion.identity);
        Debug.Log("Shoot éffectué");
    }
}
