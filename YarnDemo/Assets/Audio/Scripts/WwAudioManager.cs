using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class WwAudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [YarnCommand("MainMenuMusic")]
    public void MainMenuMusic()
    {
        AkSoundEngine.PostEvent("Main_menu_music", gameObject);
        AkSoundEngine.SetState("Menu_or_BG", "Menu");
    }

    [YarnCommand("BGMusic")]
    public void BGMusic()
    {
        AkSoundEngine.PostEvent("BG_music", gameObject);
        AkSoundEngine.SetState("Menu_or_BG", "BG");
        
    }

    [YarnCommand("MonologueMusic")]
    public void MonologueMusic()
    {
        AkSoundEngine.SetState("Mon", "Monologue");
    }
}
