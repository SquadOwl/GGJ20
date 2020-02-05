using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerBar : MonoBehaviour
{
 
    public float startTime = 20;

    public float time;
    public float _timer=1f;
    public float step=0.5f;

    public Image img;
    public SpriteRenderer sr;

    public SwitchGame game;

    
   
    public GameObject win;
    public GameObject lose;

    public bool isGameWin = false;
    private bool isGameOver=false;
    private bool isGameEnd;
    private bool isTimerPaused;

    private void Start()
    {
        time = startTime;
        
    }
    


    void Update()
    {
   
        if(isGameWin && !win.active)
        {
            _timer = 6f;
            isGameOver = true;
            SoundManager.Instance.Play("WinSound");
            win.active = true;
            
            
        }
        
        if(isGameOver )
        {
            _timer = _timer - step * Time.deltaTime;
            if(_timer<0)
            SceneManager.LoadScene(0);
        }




        img.fillAmount = time / startTime;
        if(sr.enabled && !game.IsPause && !isGameWin)
        {

            time -= Time.deltaTime;
        }

        if(time <= 0 && !isGameEnd)
        {
            _timer = 1.3f;
            lose.active = true;
            isGameOver = true;
            isGameEnd = true;
            SoundManager.Instance.Play("LoseSound");

            
        }


    }

}
