using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Building : MonoBehaviour
{

    public int health = 0;

    public int repairedHealth;

    public bool isRepaired;

    public GameObject HealthBar;

    public HealthBar bar;

    public void Start()
    {
        bar.currentFill = 0;
    }

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

    public void Update()
    {
        bar.currentFill = (float)health / repairedHealth;
    }
}
