using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchGameMode : MonoBehaviour
{
    public GameObject UsersPanel;
    public GameObject oppositeButton;
    // Start is called before the first frame update
    void Start()
    {
        UsersPanel.SetActive(false);
        bool IsSinglePlayer = gameObject.tag == "singlePlayerBtn";
        var button = GetComponent<Button>();

        button.onClick.AddListener(delegate
        {
            button.GetComponentsInChildren<Image>()[1].color = Color.cyan;
            oppositeButton.GetComponentsInChildren<Image>()[1].color = Color.magenta;

            if (IsSinglePlayer)
                UsersPanel.SetActive(false);
            else
                UsersPanel.SetActive(true);
        });
    }

}
