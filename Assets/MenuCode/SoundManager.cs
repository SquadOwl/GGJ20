using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public static float soundSize = 0;
    public static float musicSize = 0;
    public Slider soundSlider;
    public Slider volumeSlider;
    // Start is called before the first frame update
    void Start()
    {
        soundSlider.onValueChanged.AddListener(delegate {
            var soundSize = soundSlider.value;
            //set sound size code
        });

        volumeSlider.onValueChanged.AddListener(delegate {
            var volumeSize = volumeSlider.value;
            //set volume size code
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
