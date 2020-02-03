using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public List<Button> menuButtons;
    public List<GameObject> popUpCanvases;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < menuButtons.Count; ++i)
        {
            int index = i;
            menuButtons[i].onClick.AddListener(delegate { changeVisibleObject(index); }); 
        }
    }

    public void changeVisibleObject(int btnIndex)
    {
        gameObject.SetActive(false);

        if (btnIndex >= popUpCanvases.Count)
        {
            Debug.Log("Button \"" + menuButtons[btnIndex].name + "\" has no pop up object");
            return;
        }

        popUpCanvases[btnIndex].SetActive(true);
    }
}
