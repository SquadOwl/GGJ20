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
        if(MenuAll!=null)
        MenuAll.active = IsPause;
        if (MainMusic != null)
            MainMusic.active = IsPause;
        if (ARcamera != null)
            ARcamera.active = IsPause;
        if (Camera != null)
            Camera.active = !IsPause;
        if (MenuPanel != null)
            MenuPanel.active = !IsPause;

        IsPause = !IsPause;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
