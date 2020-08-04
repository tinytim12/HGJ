using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeVolumeLevels : MonoBehaviour
{
    public Slider thisSlider;
    public float masterVolume;
    public float musicVolume;
    public float sfxVolume;
    public float ambienceVolume;
    public float dialogueVolume;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetSpecificVolume (string whatValue)
    {
        float sliderValue = thisSlider.value;

        if (whatValue == "Master")
        {
            masterVolume = thisSlider.value;
        }

        if (whatValue == "Music")
        {
            musicVolume = thisSlider.value;
        }

        if (whatValue == "SFX")
        {
            sfxVolume = thisSlider.value;
        }

        if (whatValue == "Ambience")
        {
            ambienceVolume = thisSlider.value;
        }

        if (whatValue == "Dialogue")
        {
            dialogueVolume = thisSlider.value;
        }
    }
}
