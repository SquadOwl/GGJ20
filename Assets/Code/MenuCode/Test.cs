using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        RectTransform rt = (RectTransform)transform;
        float width = rt.rect.width;
        float height = rt.rect.height;
        transform.localScale = new Vector3(2, 2, 2);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
