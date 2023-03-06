using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrack : MonoBehaviour
{
    public Item item;

    private void Awake()
    {
        item.health = item.maxHealth;
    }

    public void Damage(int damageTaken)
    {
        if (item.health > 0)
        {
            item.health -= damageTaken;
        }
    }

    public void Kill()
    {
        if (item.health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            //Damage(takeDamage);

            switch (item.type)
            {
                case ItemType.Barrack:
                    Damage(10);
                    Kill();
                    break;
                case ItemType.PowerPlant:
                    Damage(10);
                    Kill();
                    break;
                default:
                    break;
            }

        }
    }
}
