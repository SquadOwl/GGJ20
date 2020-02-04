using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchGame : MonoBehaviour
{
  
    public GameObject MenuAll;
    public GameObject ARcamera;
    public GameObject Camera;
    public GameObject MainMusic;
    public GameObject MenuPanel;
    public bool IsPause;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    public void Pause()
    {
        Debug.Log(IsPause);
        
        MenuAll.active = IsPause;
 
        MainMusic.active = IsPause;
        ARcamera.active = IsPause;
        Camera.active = !IsPause;
        MenuPanel.active = !IsPause;

        IsPause = !IsPause;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
