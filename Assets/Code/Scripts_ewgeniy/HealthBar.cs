using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public float currentFill = 1;

    public GameObject sprite;

    Vector3 startScale;

    public void Start()
    {
        startScale = sprite.transform.localScale;
    }

    public void Update()
    {
        sprite.transform.localScale = new Vector3(startScale.x * currentFill, startScale.y, startScale.z);
        //sprite.transform.position = new Vector3(sprite.transform.position.x - , sprite.transform.position.y, sprite.transform.position.z);
    }
}
