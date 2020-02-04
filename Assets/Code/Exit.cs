using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public GameObject menu;
    public GameObject popup;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    public void Exit_is()
    {
        if (menu != null)
            menu.active = false;
        popup.gameObject.active = true;
    }

    public void Ok()
    {
        Debug.Log("EXIT");
        Application.Quit();
        //System.Diagnostics.Process.GetCurrentProcess().Kill();
    }


    public void BackMenu()
    {
        Debug.Log("Menu");
        SceneManager.LoadScene(0);
    }

    public void No()
    {
        if (menu != null)
            menu.active = true;
        popup.gameObject.active = false;
    }
}
