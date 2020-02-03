using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Exit_1 : MonoBehaviour
{

    void Start()
    {
        (GetComponent<Button>()).onClick.AddListener(delegate
        {

            
            Application.Quit();

        });
    }


   
}
