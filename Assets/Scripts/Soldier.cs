using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier : MonoBehaviour, IDamageable<int>, IKillable
{
    public int Health { get; set; } = 100;


    public void Damage(int damageTaken) //fonksiyonu kullandiginda icine ne verirsen onu dusecek
    {
        Health -= damageTaken;
    }

    public void Kill()
    {
        Health = 0;
    }
}
