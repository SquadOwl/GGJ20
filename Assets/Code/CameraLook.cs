using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    GameObject camera;
    //// Start is called before the first frame update
    //void Start()
    //{


    //    camera = GameObject.FindGameObjectWithTag("MainCamera");
    //}

    //// Update is called once per frame
    //void Update()
    //{

    //    //  transform.LookAt(new Vector3(0, camera.transform.position.x, 0));
    //    //  camera.transform.LookAt(new Vector3(0,camera.transform.position.x,0));

    //    transform.LookAt(new Vector3(camera.transform.position.y,0,0));
    //}


    public double dx;
    public double dy;

    // Use this for initialization
    void Start()
    {
        camera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(new Vector3(0, 0, 5));
    }
}
