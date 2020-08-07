using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WwPlayMusicEvent : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        AkSoundEngine.RegisterGameObj(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayMenuMusic()
    {
        AkSoundEngine.PostEvent("Menu_music", gameObject);
    }

    public void PlayBGMusic()
    {
        AkSoundEngine.PostEvent("BG_music", gameObject);
    }

    public void StopBGMusic()
    {
        AkSoundEngine.PostEvent("BG_music_stop", gameObject);
    }

}
