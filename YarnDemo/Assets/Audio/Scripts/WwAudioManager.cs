using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class WwAudioManager : MonoBehaviour
{
    public GameObject audioManager;
    // Start is called before the first frame update
    void Start()
    {
        //BGMusic();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    [YarnCommand("MainMenuMusic")]
    public void MainMenuMusic()
    {
        AkSoundEngine.PostEvent("Main_menu_music", audioManager);
        AkSoundEngine.SetState("Menu_or_BG", "Menu");
        
    }

    [YarnCommand("BGMusic")]
    public void BGMusic()
    {
        AkSoundEngine.PostEvent("BG_music", audioManager);
        AkSoundEngine.SetState("Menu_or_BG", "BG");
        MonologueMusic();
        Debug.Log("background music plays");
        
    }

    [YarnCommand("MonologueMusic")]
    public void MonologueMusic()
    {
        AkSoundEngine.SetState("Mon", "Monologue");
        Debug.Log("monologue music plays");
    }
}
