using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Bow", menuName = "Bow")]
public class Bow : ScriptableObject
{
    [Header("Basic informmation")]
    public new string name;
    public string description;

    [Header("Visuel")]
    public Sprite artwork;

    [Header("Statistic")]
    public int _degat;
    public int cooldown;
    public int nombreDeFlecheTirerEnUneSeulFoi;

    public enum Effect { None, Burn, Froze, Poison, Paralize }
    [Header("Effet de l'arme")]
    public Effect effet;
}
