using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float speed = 100f;

    private void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.gameObject.CompareTag("Alien"))
        //{
        //    //Destroy(gameObject);
        //    collision.gameObject.GetComponent<Alien>().Kill();
        //    gameObject.SetActive(false);
        //}

    }


}
