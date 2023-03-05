using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Soldier Type")]
public class SoldierType : ScriptableObject
{
    public Soldiers soldiers;
    public Sprite image;
}

public enum Soldiers
{
    Soldier1,
    Soldier2,
    Soldier3
}
