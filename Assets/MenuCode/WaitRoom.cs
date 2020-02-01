using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WaitRoom : MonoBehaviour
{
    public GameObject loadingIcon;

    // Start is called before the first frame update
    void Start()
    {
        var images = this.GetComponentsInChildren<RawImage>();

        for (int i = 0; i < 6 || i < images.Length; i++)
        {
            if (i < 4)
                images[i].color = new Vector4(0.96f, 0.21f, 0.21f, 1);

            else
                images[i].color = new Vector4(0.91f, 0.6f, 0.6f, 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (true)
        {
            loadingIcon.transform.Rotate(Vector3.back * 50 * Time.deltaTime, 5);
            //loadingIcon.transform.Rotate(0, 0, Time.deltaTime * -200);
            //var desiredRotQ = Quaternion.Euler(Vector3.back);
            //loadingIcon.transform.rotation = Quaternion.Lerp(transform.rotation, desiredRotQ, Time.deltaTime * 50);
            //loadingIcon.transform.Rotate(Vector3.back * 300 * Time.deltaTime);
        }


        else
            SceneManager.LoadScene("GameScene");
    }
}
