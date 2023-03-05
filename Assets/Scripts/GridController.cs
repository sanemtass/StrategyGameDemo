using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GridController : MonoBehaviour
{
    public static GridController Instance;

    [SerializeField] private Tilemap tilemap;
    [SerializeField] private Vector3 point;
    public Vector3 positionToGo;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        SelectUnit();
    }

    private void SelectUnit()
    {
        if (Input.GetMouseButtonDown(1))
        {
            point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            positionToGo = tilemap.WorldToCell(point);
        }
    }
}
