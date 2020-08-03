﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class WwAudioManager : MonoBehaviour
{
    public GameObject MusicManager;
    public string MainMenu = "Main_menu";
    public string BG = "BG";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BGMusic();
    }

    public void MainMenuMusic()
    {
        AkSoundEngine.PostEvent(MainMenu, MusicManager);
    }

    public void BGMusic()
    {
        AkSoundEngine.PostEvent(BG, MusicManager);
    }

}