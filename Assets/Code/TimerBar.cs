using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerBar : MonoBehaviour
{
    public float startTime = 20;

    public float time;

    public Image img;
    public SpriteRenderer sr;

    private bool isGameEnd;
    private bool isTimerPaused;

    private void Start()
    {
        time = startTime;
        
    }
    


    void Update()
    {
        img.fillAmount = time / startTime;
        if(sr.enabled)
        {
            Debug.Log(time);
            time -= Time.deltaTime;
        }
        if(time <= 0 && !isGameEnd)
        {
            isGameEnd = true;
            SoundManager.Instance.Play("LoseSound");

            SceneManager.LoadScene(0);
        }
    }

}
