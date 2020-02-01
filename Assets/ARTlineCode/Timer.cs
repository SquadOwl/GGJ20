using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float m_CurrentTime;
    private float m_StartTime = 1;

    public float CurrentTime { get => m_CurrentTime; }

    public Timer(float time)
    {
        m_StartTime = time;
        m_CurrentTime = m_StartTime;
    }

    public bool IsEnd()
    {
        return m_CurrentTime <= 0;
    }

    public void Reset()
    {
        m_CurrentTime = m_StartTime;
    }

    public void Update()
    {
        m_CurrentTime -= Time.deltaTime;        
    }
}
