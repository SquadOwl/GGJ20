using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + " Enter");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.name + " Exit");
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log(other.name + " Here");
    }


}
