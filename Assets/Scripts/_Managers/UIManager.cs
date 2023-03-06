using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public Item item1, item2;
    public SoldierType soldier1, soldier2, soldier3;
    public Image itemImage;
    public Image soldier1Image, soldier2Image, soldier3Image;
    public TextMeshProUGUI itemText;

    public string objectName;

    private void Awake()
    {
        Instance = this;
    }

    public void InitializeItem(Item newItem)
    {
        itemImage.sprite = newItem.image;
        itemText.text = newItem.name;
    }

    public void InitializeSoldier(SoldierType soldier1, SoldierType soldier2, SoldierType soldier3)
    {
        soldier1Image.sprite = soldier1.image;
        soldier2Image.sprite = soldier2.image;
        soldier3Image.sprite = soldier3.image;
    }

    public void Upgrade()
    {
        switch (objectName)
        {
            case ("Barrack(Clone)"):
                InitializeItem(item1);
                InitializeSoldier(soldier1, soldier2, soldier3);
                break;
            case ("PowerPlant(Clone)"):
                InitializeItem(item2);
                break;
        }
    }

    

}
