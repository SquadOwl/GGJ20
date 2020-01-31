using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : AttackItem
{
    public Gun()
    {
        damage = 5;
        speed = 2;
        distance = 10;
    }


    public override void Attack()
    {
        Debug.Log("Gun: damage: " + damage + " distance:" + distance + " speed:" + speed);
    }

}
