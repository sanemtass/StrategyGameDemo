using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateSoldier : MonoBehaviour
{
    [SerializeField] private Transform spawnPoint;
    public SoldierType soldierType;
    public Image img;
    public GameObject soldier;

    private void Start()
    {
        InitializeSoldier(soldierType);
    }

    public void SpawnSoldier()
    {
        if (spawnPoint.position != null)
        {
            Instantiate(soldier, spawnPoint.position, Quaternion.identity);
        }
    }

    public void InitializeSoldier(SoldierType soldierType)
    {
        img.sprite = soldierType.image;
    }
}
