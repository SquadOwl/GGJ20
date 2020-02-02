using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectControl : IControl
{
    /*public float MoveSpeed; // Скорость огибания по синусоиде, влияющая на угол
    public float frequency; // Скорость виляния по синусоиде
    public float magnitude; // Размер синусоиды (радиус)

    private Vector3 axis;
    private Vector3 pos;

    int direction;*/
    float colliderRadius;
   /* bool isHaveOne;*/
    Transform endPoint;

    public ObjectControl(Transform transform)
    {
       /* direction = 1;

        MoveSpeed = 4.0f;
        frequency = 1.0f;
        magnitude = 5.0f;

        pos = transform.position;*/

        endPoint = null;
        colliderRadius = 15f;
        /*isHaveOne = false;*/
    }

    void ExplosionBreakables(Vector3 center, float radius)
    {
        Collider[] colliders = Physics.OverlapSphere(center, radius);
        foreach (Collider item in colliders)
        {
            if (item.gameObject.GetComponent<Breakable>() != null)
            {
                endPoint = item.gameObject.GetComponent<Breakable>().transform;
                /*isHaveOne = true;*/
                break;
            }
        }
    }

    /*void ExplosionWalls(Transform transform, Vector3 center, float radius)
    {
        Collider[] colliders = Physics.OverlapSphere(center, radius);
        foreach (Collider item in colliders)
        {
            if (item.gameObject.GetComponent<Wall>() != null)
            {
                if (direction == 1 || direction == 4)
                {
                    float rnd = Random.Range(0, 2);
                    if (rnd>0)
                    {
                        direction = 2;
                    }
                    else
                    {
                        direction = 3;
                    }
                    break;
                }
                else
                {
                    float rnd = Random.Range(0, 2);
                    if (rnd > 0)
                    {
                        direction = 1;
                    }
                    else
                    {
                        direction = 4;
                    }
                    break;
                }
            }
        }
    }*/


    /*void MoveSin(Transform transform, Vector3 axisDirect, Vector3 sinDirect, bool isRightOrForward)//transform.right,transform.forward
    {
        axis = axisDirect;
        Vector3 moveDirection = transform.position;
        if (isRightOrForward)
            pos += sinDirect * Time.deltaTime * MoveSpeed;
        else
            pos -= sinDirect * Time.deltaTime * MoveSpeed;
        transform.position = pos + axis * Mathf.Sin(Time.time * frequency) * magnitude;
    }*/

    /*void MoveToDir(Transform transform)// 1 2 3 4 - ᐊ ᐁ ᐃ ᐅ
    {
        if (direction == 1)
        {
            MoveSin(transform, transform.forward, transform.right, false);
        }
        else if (direction == 2)
        {
            MoveSin(transform, transform.right, transform.forward, false);
        }
        if (direction == 3)
        {
            MoveSin(transform, transform.right, transform.forward, true);
        }
        if (direction == 4)
        {
            MoveSin(transform, transform.forward, transform.right, true);
        }
    }*/
    
    // Update is called once per frame
    public void Move(Transform transform)
    {
        /*if (!isHaveOne)
        {
            ExplosionWalls(transform, transform.position, colliderRadius);
            MoveToDir(transform);
            ExplosionBreakables(transform.position, colliderRadius);
        }
        else
        {*/
        ExplosionBreakables(transform.position, colliderRadius);
        transform.position = Vector3.MoveTowards(transform.position, endPoint.position, Time.deltaTime);
       /* }*/
    }
}
