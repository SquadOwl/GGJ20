using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class Board : MonoBehaviour
{

    private int boardHealth;

    public int FULLboardHealth;

    public GameObject _time;
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

        foreach (var obj in buildings)
        {
            FULLboardHealth += obj.repairedHealth;
        }
    }

    public void RepairBuild()
    {
        boardHealth = 0;
        foreach (var obj in buildings)
        {
            boardHealth += obj.GetHealth();
        }
        Debug.Log("boardHealth=" + boardHealth);

        if(FULLboardHealth== boardHealth)
        {
            _time.GetComponent<TimerBar>().isGameWin=true;
        }

    }

    public void Update()
    {
       

    }
}
