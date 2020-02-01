using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//enum Direction { UP, DOWN, LEFT, RIHGT };

[RequireComponent(typeof(LineRenderer))]
public class Lazer : MonoBehaviour
{
    [SerializeField] float lazerOffTime = .01f;
    [SerializeField] float maxDistance = 150f;
    LineRenderer lr;
    bool canFire = true;
    float timerCounter = 0;
    //Direction direction = 0;

    private void Awake()
    {
        lr = GetComponent<LineRenderer>();
    }

    private void Start()
    {
        lr.enabled = false;  
    }

    private void Update()
    {
        if(timerCounter > 0)
        {
            timerCounter -= Time.deltaTime;
            if (timerCounter < 0)
            {
                TurnOffLazer();
            }
        }
    }

    public void Direction(int dirDegree)
    {
        transform.localRotation = Quaternion.Euler(0, dirDegree, 0);
    }

    public void Fire(float countdown)
    {
        FireLazer(transform.forward * maxDistance);
        timerCounter = countdown;
    }

    public void FireLazer(Vector3 targetPosition)
    {
        if(canFire)
        {
            lr.SetPosition(1, new Vector3(0, 0, 150));
            lr.enabled = true;
            canFire = false;
          
        }

       // Invoke("TurnOffLazer", lazerOffTime);
    }

 

    void TurnOffLazer()
    {
        lr.enabled = false;
        canFire = true;
    }
}
