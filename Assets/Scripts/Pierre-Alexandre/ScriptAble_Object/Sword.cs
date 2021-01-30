using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Sword", menuName = "Sword")]
public class Sword : ScriptableObject
{
    [Header("Basic informmation")]
    public new string name;
    public string description;

    [Header("Visuel")]
    public Sprite artwork;

    [Header("Statistic")]
    public int attack;
    public int cooldown;

    public enum Effect {None, Burn, Froze, Poison, Paralize}
    [Header("Effet de l'arme")]
    public Effect effet;
}
