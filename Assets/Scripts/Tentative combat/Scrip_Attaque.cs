using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrip_Attaque : MonoBehaviour
{
    public int AtkValue;
    public Transform attaquePoint;
    public float attaqueRange = 0.5f;
    public LayerMask ennemyLayer;
    // Start is called before the first frame update
    void Start()
    { 

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnAttak()
    {
        Attaque();
        Debug.Log("Appelle la fonction Attaque !");
    }

    public void Attaque()
    {
        Debug.Log("Attaque a reçu l'apelle !");

        Collider2D[] hitEnnemies = Physics2D.OverlapCircleAll(attaquePoint.position, attaqueRange, ennemyLayer);

        Debug.Log("avant  l'overlapsphere");
        foreach (Collider2D enemy in hitEnnemies)
        {
            Debug.Log("l'overlapsphere fonctionne");
        }
        Debug.Log("aprés l'overlapsphere");
    }

    private void OnDrawGizmosSelected()
    {
        if (attaquePoint == null)
            return;
        Gizmos.DrawWireSphere(attaquePoint.position, attaqueRange);
    }
}
