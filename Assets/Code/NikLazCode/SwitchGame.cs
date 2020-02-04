using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchGame : MonoBehaviour
{
    public GameObject ARCamera;
    public GameObject MenuAll;
    public GameObject ImageTarget;
    public GameObject MainMusic;
    public GameObject MenuPanel;
    public bool IsPause;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(delegate {

            ARCamera.SetActive(!IsPause);
            MenuAll.SetActive(!IsPause);
            ImageTarget.SetActive(!IsPause);
            MainMusic.SetActive(!IsPause);
            MenuPanel.SetActive(IsPause);

        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
