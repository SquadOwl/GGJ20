using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SwitchViews : MonoBehaviour
{
    public GameObject fadingView;
    public GameObject popUpView;

    // Start is called before the first frame update
    void Start()
    {
        (GetComponent<Button>()).onClick.AddListener(delegate {

            if(fadingView != null)
                fadingView.SetActive(false);

            if (popUpView != null)
                popUpView.SetActive(true);

        });
    }

   
}
