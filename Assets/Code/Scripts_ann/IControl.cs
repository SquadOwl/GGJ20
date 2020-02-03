using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IControl
{
    // Start is called before the first frame update
    void Move(Transform transform);
}
