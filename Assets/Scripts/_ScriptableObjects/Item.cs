using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[CreateAssetMenu(menuName ="Scriptable object/Item")]
public class Item : ScriptableObject
{
    public new string name;
    public ItemType type;
    public Sprite image;
    public int health;
    public int maxHealth;
    public int takeDamage;
}

public enum ItemType
{
    Barrack,
    PowerPlant
}

