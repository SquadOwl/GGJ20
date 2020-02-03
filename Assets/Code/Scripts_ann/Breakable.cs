using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour
{
    Life life;
    // Start is called before the first frame update
    void Start()
    {
        life = new Life(3.0f);
        Breakables.Instance.breakablesList.Add(this);
    }

    private bool isLife()
    {
        if (life.health <= 0f)
            return false;
        else
            return true;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
