using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Market : MonoBehaviour
{
    public Sprite _destroy;
    public Sprite _fixed;
  

    public float time;
    public float time_now;
    public float step;
    // Start is called before the first frame update
    void Start()
    {
        
    }



    public void ChengeMarket(bool is_fix)
    {
        if(is_fix)
        {
            Fixed();
        }
        else
        {
            Destroy();
           
          
        }
     
    }

    void Destroy()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = _destroy;
        gameObject.active = true;
        time_now = 0;
    }
    void Fixed()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = _fixed;
        time_now = time;

    }
    // Update is called once per frame
    void Update()
    {
        if (gameObject.active)
        {

            transform.Rotate(new Vector3(0, 1, 0));

        }
        if (time_now > 0 && gameObject.active)
        {
            time_now = time_now - step / Time.deltaTime;
            if (time_now < 0)
            {
                gameObject.active = false;
            }
        }
      

        

    }
}
