using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public static ObjectPooler Instance;

    public List<GameObject> pooledBulletsList = new List<GameObject>();

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private int poolSize;

    private void Awake()
    {
        if (ObjectPooler.Instance == null) Instance = this;

        else Destroy(this);
        
    }

    private void Start()
    {
        CreateBulletPool(Mathf.CeilToInt(100));
    }

    public void CreateBulletPool(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            GameObject spawnedBullet = Instantiate(bulletPrefab);
            PoolObject(spawnedBullet);
        }
    }

    public void PoolObject(GameObject objectToPool)
    {
        objectToPool.SetActive(false);
        pooledBulletsList.Add(objectToPool);
    }

    public GameObject GetPooledObject()
    {
        GameObject obj = pooledBulletsList[0];
        pooledBulletsList.RemoveAt(0);
        obj.SetActive(true);
        return obj;
    }


}
