using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class WwAudioManager : MonoBehaviour
{
    public string MainMenu = "Main_menu_music";
    public string BG = "BG_music";
    // Start is called before the first frame update
    void Start()
    {
        BGMusic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MainMenuMusic()
    {
        AkSoundEngine.PostEvent(MainMenu, gameObject);
    }

    public void BGMusic()
    {
        AkSoundEngine.PostEvent(BG, gameObject);
    }

}
