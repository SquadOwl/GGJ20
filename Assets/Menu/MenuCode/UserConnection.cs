using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserConnection : MonoBehaviour
{
    public GameObject loadingIcon;
    public GameObject fadingView;
    public GameObject popUpView;
    public Button okBtn;
    float timeLeft = 5.0f;
    float nextSceneTimeLeft = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        okBtn.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft < 0)
        {
            okBtn.gameObject.SetActive(true);
            loadingIcon.SetActive(false);
            nextSceneTimeLeft -= Time.deltaTime;

            if (nextSceneTimeLeft < 0)
            {
                if (fadingView != null)
                    fadingView.SetActive(false);

                if (popUpView != null)
                    popUpView.SetActive(true);
            }
        }


        else
        {
            loadingIcon.transform.Rotate(Vector3.back * 50 * Time.deltaTime, 5);
            timeLeft -= Time.deltaTime;
        }
    }
}
