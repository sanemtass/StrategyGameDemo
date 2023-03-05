using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class SoldierMovementController : MonoBehaviour
{
    private AIPath aIPath;
    public bool isMoving;
    public bool isAvailable;

    private void Start()
    {
        aIPath = GetComponent<AIPath>();
    }

    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (GameManager.Instance.soldiers.Contains(gameObject))
            {
                isMoving = true;
                isAvailable = true;
            }
        }

        if (isMoving)
        {
            foreach (GameObject item in GameManager.Instance.soldiers)
            {
                aIPath.destination = GridController.Instance.positionToGo;
            }
        }

        if (Vector3.Distance(GridController.Instance.positionToGo, transform.position) < 1f)
        {
            isMoving = false;
            isAvailable = true;
        }
            

    }

    
}
