using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public List<GameObject> soldiers;

    private void Awake()
    {
        Instance = this;
    }

    public void SelectSoldiers(GameObject soldier)
    {
        if (!soldiers.Contains(soldier))
        {
            soldiers.Add(soldier);
            if (soldiers.Count > 1)
            {
                soldiers.Clear();
                soldiers.Add(soldier);
            }
                
        }
            
    }
}
