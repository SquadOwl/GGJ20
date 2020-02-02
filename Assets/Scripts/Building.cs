using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Building : MonoBehaviour
{

    private int health = 0;

    public int repairedHealth;

    public bool isRepaired;


    public int GetHealth()
    {
        return health;
    }

    public void GetRepair(int count)
    {
        health += count;
        if(health >= repairedHealth)
        {
            isRepaired = true;
        }
    }
}
