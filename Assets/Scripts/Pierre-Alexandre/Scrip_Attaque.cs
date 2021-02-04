using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrip_Attaque : MonoBehaviour
{
    [Header("Script Affillier")]
    public Inventaire inventaire;

    [Header("Statistique")]
    public float _degat;
    public float cooldown;
    public int nombreDeFlecheTirerEnUneSeulFoi;
    public GameObject[] ObjetEquiper;//objet[0] = epee simple; objet[1] = epee double; objet[2] = arc simple


    public enum Arme { none, epeeSimple, epeeDouble, arcSimple } //Variable pour faire une liste déroulante
    [Header("Général Attaque Settings")]
    public Arme armeEquipé;//Liste deroulante des arme
    public float attaqueRange = 0.5f;
    public GameObject attaquePoint;
    public bool attaqueCheck;
    private float actualCooldown = 0f;

    [Header("Epee Settings")]
    public Sword[] TypeDEpee;//liste pour mettre les scriptableObjet
    public LayerMask ennemyLayer;

    [Header("Arc Settings")]
    public Bow[] TypeDArc;
    public GameObject Munition;


    public void Start()
    {

    }
    void Update()
    {
        //la position de l'overlap = cette position(this.transform.position) + la range de l'attaque(attaqueRange) dans la direction du personnage(_direction)
        attaquePoint.transform.position = new Vector3 (
            this.transform.position.x + GetComponent<Deplacement>()._direction.x * attaqueRange, 
            this.transform.position.y + GetComponent<Deplacement>()._direction.y * attaqueRange, 
            this.transform.position.z);


        //Variable bool pour reste le cooldown
        if (actualCooldown <= 0)
        {
            attaqueCheck = true;
        }
        actualCooldown -= 1 * Time.deltaTime;
    }
    public void EpeeSimple()//Prend les stat de l'arme selectioné pour l'apliquer au stat du personnage
    {
        armeEquipé = Arme.epeeSimple;
        _degat = TypeDEpee[0]._degat;
        cooldown = TypeDEpee[0].cooldown;
        nombreDeFlecheTirerEnUneSeulFoi = 1;
    }
    public void EpeeDouble()//Prend les stat de l'arme selectioné pour l'apliquer au stat du personnage
    {
        armeEquipé = Arme.epeeDouble;
        _degat = TypeDEpee[1]._degat;
        cooldown = TypeDEpee[1].cooldown;
        nombreDeFlecheTirerEnUneSeulFoi = 1;
    }
    public void ArcSimple()//Prend les stat de l'arme selectioné pour l'apliquer au stat du personnage
    {
        armeEquipé = Arme.arcSimple;
        _degat = TypeDArc[0]._degat;
        cooldown = TypeDArc[0].cooldown;
        nombreDeFlecheTirerEnUneSeulFoi = TypeDArc[0].nombreDeFlecheTirerEnUneSeulFoi;
    }

    public void OnAttak()//quand le boutton d'attaque est préssé
    {
        if (attaqueCheck)//L'arme est elle en cooldown ?
        {
            Attack();
            actualCooldown = cooldown;
            //L'arme n'est pas en cooldown l'attaque se lance et le cooldown s'active
        }
    }

    public void Attack()
    {
        if (armeEquipé == Arme.arcSimple) //Si l'arme équipé est l'arc
        {
            Shoot();
        }
        else//Si ce n'est pas le seul arc disponible alors c'est une épée
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
    public void Shoot()//N'est pas teriminer ! la fleche ne vas pas encore dans la direction du personnage
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
