using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(fileName = "New Sword", menuName = "Sword")]
public class Sword : ScriptableObject
{
    [Header("Basic informmation")]
    public new string name;
    [TextArea]
    public string description;

    [Header("Visuel")]
    public Sprite artwork;

    [Header("Statistic")]
    public int _degat;
    public float cooldown;

    public enum Effect {None, Burn, Froze, Poison, Paralize}
    [Header("Effet de l'arme")]
    public Effect effet;
    public Sprite[] visuelEffet;
}