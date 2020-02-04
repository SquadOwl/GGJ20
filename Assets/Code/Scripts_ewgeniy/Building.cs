using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum State_obj
{
    Destroy,
    Midle,
    Fixed
}
public class Building : MonoBehaviour
{
    public Sprite _destroy;
   public Sprite _fixed;

    public Market my_state;
    public  State_obj _my_state;

    public int health = 0;

    public int repairedHealth;

    public bool isRepaired;

    public int First = 0;
    public int Second = 0;
    public int Tree = 0;

    List<Transform> Figures;
    List<Transform> Sprites;
    
    

    public GameObject HealthBar;

    public HealthBar bar;

    

    public void Start()
    {
        my_state = new Market(0, 2, 0, transform, _destroy, _fixed,3f,0.1f);
        _my_state = State_obj.Destroy;
        Sprites = new List<Transform>();
        Figures = new List<Transform>();

        my_state = null;

        for (int i=0;i< gameObject.transform.GetChildCount();i++)
        {
            Figures.Add(gameObject.transform.GetChild(i));
        }


    
        for(int i=0; i<Figures.Count;i++)
        {
            Debug.Log(i);
         
             
                for (int y = 0; y < Figures[i].transform.GetChildCount(); y++)
                {
                Debug.Log("sprite");
                
                    Sprites.Add(Figures[i].transform.GetChild(y));
                    
                }
          
        }

        ChangeImageState();

     //   bar.currentFill = 0;
    }

    public int GetHealth()
    {
        return health;
    }

    public void GetRepair(int count)
    {
        health += count;

        Repair();
        if (health >= repairedHealth)
        {
            isRepaired = true;
        }
    }

    public void Update()
    {
       
       // bar.currentFill = (float)health / repairedHealth;
    }

    public void Repair()
    {
        if(First == health)
        {
            _my_state = State_obj.Destroy;
            ChangeImageState();
        }
        else if (Second == health)
        {
            _my_state = State_obj.Midle;
            ChangeImageState();
        }
        else if (Tree == health)
        {
            _my_state = State_obj.Fixed;
            ChangeImageState();
        }
      
    }

    public void ChangeImageState()
    {
        switch (_my_state)
        {
            case State_obj.Destroy:

                if(my_state!=null)
                my_state.ChengeMarket(false);

                for (int i=0;i< Figures.Count;i++)
                {
                    Figures[i].localPosition = new Vector3(Figures[i].localPosition.x, Figures[i].localPosition.y - Figures[i].transform.localScale.y/1.5f, Figures[i].localPosition.z);
                   
                }


                for (int i = 0; i < Sprites.Count; i++)
                {
                  
                        Sprites[i].gameObject.active = false;

                }


                break;
            case State_obj.Midle:
              
                for (int i = 0; i < Figures.Count; i++)
                {
                    Figures[i].localPosition = new Vector3(Figures[i].localPosition.x, Figures[i].localPosition.y + Figures[i].transform.localScale.y / (1.5f*2f), Figures[i].localPosition.z);

                }


                for (int i = 0; i < Sprites.Count; i++)
                {

                    Sprites[i].gameObject.active = false;

                }

                break;
            case State_obj.Fixed:
                if (my_state != null)
                    my_state.ChengeMarket(true);
                for (int i = 0; i < Figures.Count; i++)
                {
                    Figures[i].localPosition = new Vector3(Figures[i].localPosition.x, Figures[i].localPosition.y + Figures[i].transform.localScale.y / (1.5f * 2f), Figures[i].localPosition.z);

                }


                for (int i = 0; i < Sprites.Count; i++)
                {

                    Sprites[i].gameObject.active = true;

                }

                break;
        }
    }
}
