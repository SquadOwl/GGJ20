using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        (GetComponent<Button>()).onClick.AddListener(delegate {

            SceneManager.LoadScene(1);

        });
    }

}
