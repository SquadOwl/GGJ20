using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleScript : MonoBehaviour
{
    public GameObject Joystik;
    public GameObject Buttons;
    // Start is called before the first frame update

    public void Active_Joystik()
    {
        Joystik.active = true;
        Buttons.active = false;
    }

    public void Active_Button()
    {
        Joystik.active = false;
        Buttons.active = true;
    }
}


