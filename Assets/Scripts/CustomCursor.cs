using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomCursor : MonoBehaviour, IClickable
{
    public Item item;
    public SoldierType soldierType = null;

    public Image image;

    [SerializeField] private GameObject barrackPrefab, powerPlantPrefab;
    private GameObject prefab;

    private void Start()
    {
        InitializeItem(item);
    }

    public void InitializeItem(Item newItem)
    {
        image.sprite = newItem.image;
    }

    public void SelectPrefab()
    {
        switch (item.type)
        {
            case ItemType.Barrack:
                prefab = barrackPrefab;
                break;
            case ItemType.PowerPlant:
                prefab = powerPlantPrefab;
                break;
        }

        GenerateObject();
    }

    private void GenerateObject()
    {
        Instantiate(prefab, mousePos(), Quaternion.identity);
    }

    private Vector3 mousePos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    public void Click()
    {
        SelectPrefab();
    }
}
