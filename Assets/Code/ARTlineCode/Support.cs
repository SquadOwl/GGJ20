using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Direction { UP,DOWN,LEFT,RIGHT};

public class Support : MonoBehaviour
{
    Collider otherCol;

    private void Start()
   {
        otherCol = null;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + " Enter");
        otherCol = other;
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.name + " Exit");
        otherCol = null;
    }

    public void Heal()
    {
        if (otherCol != null)
        {
            Debug.Log(otherCol.name + " Heal");

            SpriteRenderer f = new SpriteRenderer();
           
            otherCol.gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().color= Color.green;
            otherCol.gameObject.GetComponent<Renderer>().material.color = Color.green;

           // otherCol.gameObject.GetComponentInParent<GameObject>().active=true;
        }
    }

    //0 - UP, 1 - DOWN, 2 - LEFT, 3 - RIGHT
    public void Direction(int dir)
    {
        switch (dir)
        {
            case 0:
                transform.localPosition = new Vector3(0, -0.2f, 1);
                break;
            case 1:
                transform.localPosition = new Vector3(0, -0.2f, -1);
                break;
            case 2:
                transform.localPosition = new Vector3(-1, -0.2f, 0);
                break;
            case 3:
                transform.localPosition = new Vector3(1, -0.2f, 0);
                break;

            default:
                break;
        }

        
    }

}
