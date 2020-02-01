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
            button.GetComponentsInChildren<Image>()[1].color = new Vector4(0.45f, 0.61f, 0.61f, 1);
            oppositeButton.GetComponentsInChildren<Image>()[1].color = new Vector4(0.28f, 0.26f, 0.4f, 1);

            if (IsSinglePlayer)
                UsersPanel.SetActive(false);
            else
                UsersPanel.SetActive(true);
        });
    }

}
