﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class WwMusicManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //BGMusic();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void MainMenuMusic()
    {
        AkSoundEngine.SetState("Menu_or_BG", "Menu"); // sets it to menu
        AkSoundEngine.PostEvent("Menu_music", gameObject); //plays the music
        
    }

    public void BGMusic()
    {
        AkSoundEngine.SetState("Menu_or_BG", "BG"); //sets it to BG
        AkSoundEngine.PostEvent("BG_music", gameObject); //plays the music
        
    }

    public void BGMusicStop()
    {
        //if at canteen use this to stop bg noise
        AkSoundEngine.PostEvent("BG_music_stop", gameObject); //stops the background music
    }

    [YarnCommand("MonologueMusic")]
    public void MonologueMusic()
    {
        //need to set "Menu_or_BG" state to "BG" in order for monologue music to play
        AkSoundEngine.SetState("Monologue_or_Mrs_Thiru", "Monologue"); // sets it so it plays monologue music
        //need to put post event after set state

    }

    //Mrs Thiru Monday
    //make sure "BG_Music" post event is called after setting state to "BG" and after other set states
    public void MrsThiruMusic()
    {
        AkSoundEngine.SetState("Monologue_or_Mrs_Thiru", "Mrs_Thiru_mon"); //sets it to play Mrs Thiru music for mon
        AkSoundEngine.PostEvent("BG_Music", gameObject);
        //choices
        //set the choice of music first before the set selected, don't know if it works differently in code but works that way in wwise
        //if choice "I'm sorry" is selected set state to hopeful
        AkSoundEngine.SetState("Mrs_Thiru_choices", "Hopeful");
        //if choice "Let's discuss" is selected set state to concerned
        AkSoundEngine.SetState("Mrs_Thiru_choices", "Concerned");
        //if choice "I don't really care" is selected set state to disappointed
        AkSoundEngine.SetState("Mrs_Thiru_choices", "Disappointed");
        //if a choice is not selected, will continue playing music until a choice is selected
        AkSoundEngine.SetState("Selected_or_no", "Selected"); //set the state to selected

    }

    //will update script again when I've set it up in wwise for tue and wed
    public void JamesMusic()
    {
        //if James is chosen - James music will play
        AkSoundEngine.SetState("James_or_Siti", "James"); //sets state to James
        //choices
        //set the choice of music first before the set selected, don't know if it works differently in code but works that way in wwise
        //if choice "Actually I do" is selected set state to hopeful
        AkSoundEngine.SetState("James_choices", "Hopeful");

        //if choice "I'm sorry, I don't" is selected set state to disappointed
        AkSoundEngine.SetState("James_choices", "Disappointed");

        //set state to selected when a choice is selected
        AkSoundEngine.SetState("Selected_or_no", "Selected");

    }

    public void SitiMusic()
    {
        //if Siti is chosen - Siti music will play
        AkSoundEngine.SetState("James_or_Siti", "Siti"); //sets state to Siti
        //choices
        //set the choice of music first before the set selected, don't know if it works differently in code but works that way in wwise
        //if choice "I'm interested" set state to happy
        AkSoundEngine.SetState("Siti_choices", "Happy");
        //if choice "No, sorry" set state to hopeful
        AkSoundEngine.SetState("Siti_choices", "Hopeful");
        //if option is selected, set state to selected
        AkSoundEngine.SetState("Selected_or_no", "Selected");
    }

    public void HomeMusic()
    {

    }
}
