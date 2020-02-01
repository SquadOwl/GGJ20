using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
   public GameObject popup;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    public void Exit_is()
    {
        popup.gameObject.active = true;
    }

    public void Ok()
    {
        Debug.Log("EXIT");
        Application.Quit();
    }

    public void No()
    {
        popup.gameObject.active = false;
    }
}
