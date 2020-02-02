//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.AI;

///*public class PlayerControl : IControl
//{
//    /*NavMeshAgent main;
//    bool isDamagedPlayer;
//    float colliderRadius;
//    Vector3 startPoint;

//    public PlayerControl(NavMeshAgent navMesh, Transform transform)
//    {
//        startPoint = new Vector3(transform.position.x, transform.position.y, transform.position.z);
//        main = navMesh;
//        isDamagedPlayer = false;
//        colliderRadius = 1f;
//    }

//    void ExplosionPlayer(Vector3 center, float radius)
//    {
//        Collider[] colliders = Physics.OverlapSphere(center, radius);
//        foreach (Collider item in colliders)
//        {
//            if (item.gameObject == GameObject.FindGameObjectWithTag("Player"))
//            {
//                isDamagedPlayer = true;
//            }
//        }
//    }
//    void ExplosionCoords(Vector3 center)
//    {
//        if (center == startPoint)
//        {
//            isDamagedPlayer = false;
//        }
//    }

//    // Update is called once per frame
//    public void Move(Transform transform)
//    {
//        if (!isDamagedPlayer)
//        {
//            main.SetDestination(GameObject.FindGameObjectWithTag("Player").transform.position);
//            ExplosionPlayer(transform.position, colliderRadius);
//        }
//        else
//        {
//            main.SetDestination(startPoint);
//            ExplosionCoords(transform.position);
//        }
//    }*/
//}
