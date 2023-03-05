using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletForce = 20f;

    private bool isShooting;
    private float timeToDestroy = 2f;

    private void Start()
    {
        ObjectPooler.Instance.CreateBulletPool(Mathf.CeilToInt(30));
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1) && !isShooting && GetComponent<SoldierMovementController>().isAvailable)
        {
            Shoot();
            GetComponent<SoldierMovementController>().isAvailable = false;
        }
    }

    private void Shoot()
    {
        isShooting = true;
        GameObject obj = ObjectPooler.Instance.GetPooledObject();
        obj.transform.position = firePoint.transform.position;
        obj.transform.rotation = firePoint.transform.rotation;
        Rigidbody2D rb = obj.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        isShooting = false;
        StartCoroutine(DestroyBullet(obj));
    }

    private IEnumerator DestroyBullet(GameObject bulletToDestroy)
    {
        yield return new WaitForSeconds(timeToDestroy);
        ObjectPooler.Instance.PoolObject(bulletToDestroy);
    }

}

