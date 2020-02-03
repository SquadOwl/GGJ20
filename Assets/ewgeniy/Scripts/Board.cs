using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class Board : MonoBehaviour
{

    private int boardHealth;

    public List<Building> buildings;

    public int GetBoardHealth()
    {
        return boardHealth;
    }

    public void Awake()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Building");
        foreach (var obj in objects)
        {
            Building building = obj.GetComponent<Building>();
            if (building != null)
            {
                buildings.Add(building);
                Debug.Log(building.GetHealth());
            }
        }
    }

    public void Update()
    {
        foreach(var obj in buildings)
        {
            boardHealth += obj.GetHealth();
        }
    }
}
