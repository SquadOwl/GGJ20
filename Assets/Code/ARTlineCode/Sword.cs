using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : AttackItem
{
    public Sword()
    {
        damage = 1;
        speed = 5;
        distance = 4;
    }


    public override void Attack()
    {
        Debug.Log("Gun: damage: " + damage + " distance:" + distance + " speed:" + speed);
    }

}
