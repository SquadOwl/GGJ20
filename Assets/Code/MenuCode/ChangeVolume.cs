using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ChangeVolume : MonoBehaviour
{
    public Slider soundSlider;
    public Slider volumeSlider;
    public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        soundSlider.onValueChanged.AddListener(delegate {
            source.volume = soundSlider.value;
            //set sound size code
        });

        volumeSlider.onValueChanged.AddListener(delegate {
            source.volume = volumeSlider.value;
            //set volume size code
        });
    }

    // Update is called once per frame
    void Update()
    {

    }
}
