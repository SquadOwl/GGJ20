using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakables : Singleton<Breakables>
{
    public List<Breakable> breakablesList;

    Breakables()
    {
        breakablesList = new List<Breakable>();
    }
}
