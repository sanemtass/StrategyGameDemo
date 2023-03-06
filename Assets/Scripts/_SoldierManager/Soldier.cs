using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier : MonoBehaviour, IDamageable<int>, IKillable
{
    public SoldierType soldierType;

    [SerializeField] private bool isRealize = true;

    private void Awake()
    {
        soldierType.health = soldierType.maxHealth;
    }

    private void Update()
    {
        if (soldierType.soldiers == Soldiers.Soldier1)
        {
            if (isRealize == false)
            {
                soldierType.health = soldierType.maxHealth;
            }
        }

        if (soldierType.soldiers == Soldiers.Soldier2)
        {
            if (isRealize == false)
            {
                soldierType.health = soldierType.maxHealth;
            }
        }

        if (soldierType.soldiers == Soldiers.Soldier3)
        {
            if (isRealize == false)
            {
                soldierType.health = soldierType.maxHealth;
            }
        }

    }

    public void Damage(int damageTaken)
    {
        if (soldierType.health > 0)
        {
            soldierType.health -= damageTaken;
        } 
    }

    public void Kill()
    {
        if (soldierType.health <= 0)
        {
            Destroy(gameObject);
            isRealize = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            //Damage(takeDamage);

            switch (soldierType.soldiers)
            {
                case Soldiers.Soldier1:
                    Damage(5);
                    Kill();
                    break;
                case Soldiers.Soldier2:
                    Damage(10);
                    Kill();
                    break;
                case Soldiers.Soldier3:
                    Damage(2);
                    Kill();
                    break;
                default:
                    break;
            }

            Debug.Log(soldierType.health);
        }
    }
}
