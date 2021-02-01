using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrip_Attaque : MonoBehaviour
{
    //public GameObject[] Weapon;
    [Header("Stat")]
    //public bool melee;
    public static int _degat;
    public float cooldown;
    public int nombreDeFlecheTirerEnUneSeulFoi;

    public enum Arme { none, epeeSimple, epeeDouble, arcSimple }
    [Header("Arme équipée")]
    public Arme arme;
    public float attaqueRange = 0.5f;
    public GameObject attaquePoint;

    [Header("Epee")]
    public Sword[] TypeDEpee;
    public LayerMask ennemyLayer;

    [Header("Arc")]
    public Bow[] TypeDArc;
    public GameObject Munition;

    private bool attaqueCheck;
    private float actualCooldown = 0f;

    void Update()
    {
        attaquePoint.transform.position = new Vector3 (
            this.transform.position.x + GetComponent<Deplacement>()._direction.x * attaqueRange, 
            this.transform.position.y + GetComponent<Deplacement>()._direction.y * attaqueRange, 
            this.transform.position.z);


        if(arme.ToString() == "epeeSimple")
        {
            Debug.Log("EpeeSimple");
            EpeeSimple();
        }

        if(arme.ToString() == "epeeDouble")
        {
            Debug.Log("EpeeDouble");
            EpeeDouble();
        }

        if(arme.ToString() == "arcSimple")
        {
            Debug.Log("ArcSimple");
            ArcSimple();
        }

        if(arme.ToString() == "none")
        {
            Debug.Log("Aucune épée en main");
        }

        if (actualCooldown <= 0)
        {
            attaqueCheck = true;
        }
    }
    public void EpeeSimple()
    {
        arme = Arme.epeeSimple;
        _degat = TypeDEpee[0]._degat;
        cooldown = TypeDEpee[0].cooldown;
        nombreDeFlecheTirerEnUneSeulFoi = 1;
    }
    public void EpeeDouble()
    {
        arme = Arme.epeeDouble;
        _degat = TypeDEpee[1]._degat;
        cooldown = TypeDEpee[1].cooldown;
        nombreDeFlecheTirerEnUneSeulFoi = 1;
    }
    public void ArcSimple()
    {
        arme = Arme.arcSimple;
        _degat = TypeDArc[0]._degat;
        cooldown = TypeDArc[0].cooldown;
        nombreDeFlecheTirerEnUneSeulFoi = TypeDArc[0].nombreDeFlecheTirerEnUneSeulFoi;
    }

    public void OnAttak()
    {
        if (attaqueCheck)
        {
            Attaque();
            actualCooldown = cooldown;
        }
    }

    public void Attaque()
    {
        if (arme == Arme.arcSimple)
        {
            Shoot();
        }
        else
        {
            meleeAttak();
        }
    }
    
    public void meleeAttak()
    {
        Collider[] hitEnnemies = Physics.OverlapSphere(attaquePoint.transform.position, attaqueRange, ennemyLayer);

        foreach (Collider enemy in hitEnnemies)
        {
            Debug.Log("Attaque a l'épée !");
        }
    }
    public void Shoot()
    {
        Instantiate(Munition, new Vector3(attaquePoint.transform.position.x, attaquePoint.transform.position.y, 0), Quaternion.identity);
        Debug.Log("Tire a l'arc !");
    }

    private void OnDrawGizmosSelected()
    {
        if (attaquePoint == null)
            return;
        Gizmos.DrawWireSphere(attaquePoint.transform.position, attaqueRange);
    }
}
