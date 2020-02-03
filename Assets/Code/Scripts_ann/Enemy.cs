using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    
    public int type;
    Life life;
    IControl control;
    // Start is called before the first frame update
    void Start()
    {
        type = 1;
           life = new Life(1.0f);
        if (type == 1)
        {
            control = new ObjectControl(transform);
        }
        else if (type == 2)
        {
            control = new PlayerControl(GetComponent<NavMeshAgent>(), transform);
        }
    }


    // Update is called once per frame
    void Update()
    {
        control.Move(transform);
    }
}
