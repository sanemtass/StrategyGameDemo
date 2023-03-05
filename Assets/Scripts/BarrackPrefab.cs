using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrackPrefab : MonoBehaviour
{
    public static BarrackPrefab instance;
    public bool isSelected;
    [SerializeField] private GameObject production;
    [SerializeField] private GameObject informationMenu;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            if (hit.collider != null)
            {
                Debug.Log(hit.collider.gameObject.name);
                UIManager.Instance.objectName = hit.collider.gameObject.name;

                GameManager.Instance.SelectSoldiers(hit.collider.gameObject);

                if (UIManager.Instance.objectName == ("PowerPlant(Clone)"))
                {
                    informationMenu.SetActive(true);
                    production.SetActive(false);
                    UIManager.Instance.Upgrade();
                }
                if (UIManager.Instance.objectName == ("Barrack(Clone)"))
                {
                    informationMenu.SetActive(true);
                    production.SetActive(true);
                    UIManager.Instance.Upgrade();
                }
                isSelected = true;

            }
        }
    }
}
