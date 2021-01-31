using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Epee : MonoBehaviour
{
    public int AtkValue;
    public Transform attaquePoint;
    public float attaqueRange = 0.5f;
    public LayerMask ennemyLayer;
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("le script est bien dans la scene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Melee()
    {

        Collider[] hitEnnemies = Physics.OverlapSphere(attaquePoint.position, attaqueRange, ennemyLayer);

        foreach (Collider enemy in hitEnnemies)
        {
            Debug.Log("Attaque a l'épée !");
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (attaquePoint == null)
            return;
        Gizmos.DrawWireSphere(attaquePoint.position, attaqueRange);
    }
}
