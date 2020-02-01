using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class Lazer : MonoBehaviour
{
    [SerializeField] float lazerOffTime = 10f;
    [SerializeField] float maxDistance = 150f;
    LineRenderer lr;
    bool canFire = false;

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
        FireLazer(transform.forward * maxDistance);
    }

    public void FireLazer(Vector3 targetPosition)
    {
        if(canFire)
        {
            //lr.SetPosition(0, transform.position);
            lr.SetPosition(1, targetPosition);
            lr.enabled = true;
            canFire = false;
        }
     

        Invoke("TurnOffLazer", lazerOffTime);
    }

    void TurnOffLazer()
    {
        lr.enabled = false;
        canFire = true;
    }
}
