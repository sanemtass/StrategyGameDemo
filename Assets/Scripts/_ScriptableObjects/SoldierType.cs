using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Soldier Type")]
public class SoldierType : ScriptableObject
{
    public Soldiers soldiers;
    public Sprite image;
    public int health = 10;
    public int maxHealth = 10;
    public int takeDamage;
}

public enum Soldiers
{
    Soldier1,
    Soldier2,
    Soldier3
}
