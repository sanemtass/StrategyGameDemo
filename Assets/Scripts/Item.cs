using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[CreateAssetMenu(menuName ="Scriptable object/Item")]
public class Item : ScriptableObject
{
    public new string name;
    public ItemType type;
    //public ProductionType productionType;
    public Sprite image;
}

public enum ItemType
{
    Barrack,
    PowerPlant
}

//public enum ProductionType
//{
//    Default,
//    Soldier
//}
