using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPrefab : MonoBehaviour
{
    private bool draggable = true;

    private void Update()
    {
        GenerateObjectMovement();
    }

    private void GenerateObjectMovement()
    {
        if (draggable)
            transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 5f));

        if (Input.GetMouseButtonDown(0))
        {
            AstarPath.active.Scan();
            draggable = false;
        }
            
    }

   
}
