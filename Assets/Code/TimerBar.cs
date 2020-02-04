using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerBar : MonoBehaviour
{
    public float startTime = 20;

    public float time;

    public Image img;

    private bool isGameEnd;

    private void Start()
    {
        time = startTime;
    }

    void Update()
    {
        img.fillAmount = time / startTime;
        time -= Time.deltaTime;
        if(time <= 0 && !isGameEnd)
        {
            isGameEnd = true;
            SoundManager.Instance.Play("LoseSound");
            Quit();
        }
    }

    private void Quit()
    {
        Application.Quit();
    }
}
