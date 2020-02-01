using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    GameObject camera;
    GameObject image;
    // Start is called before the first frame update
    void Start()
    {


        camera = GameObject.FindGameObjectWithTag("MainCamera");
        image = GameObject.FindGameObjectWithTag("Target");
    }

    // Update is called once per frame
    void Update()
    {

        //  transform.LookAt(new Vector3(0, camera.transform.position.x, 0));
        //  camera.transform.LookAt(new Vector3(0,camera.transform.position.x,0));

        // transform.LookAt(new Vector3(10, image.transform.position.y, image.transform.position.z));
   
       // Vector3 newDir = Vector3.RotateTowards(transform.forward, (camera.transform.position - transform.position),2f, 0.0F);
      //  transform.rotation = Quaternion.LookRotation(newDir);
        transform.Rotate(new Vector3(0, 5, 0));
    }



}
