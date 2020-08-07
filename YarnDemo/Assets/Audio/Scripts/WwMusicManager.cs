using System.Collections;
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
        //note: post event line for all the music in BG music goes after the set states
        //e.g. setstate "BG", "James" then post event "BG_music"
        AkSoundEngine.SetState("Menu_or_BG", "BG"); //sets it to BG
        AkSoundEngine.PostEvent("BG_music", gameObject); //plays the music
        
    }

    public void BGMusicStop()
    {
        //if at canteen use this to stop bg noise
        AkSoundEngine.PostEvent("BG_music_stop", gameObject); //stops the background music
    }

    public void MonologueMusic()
    {
        //need to set "Menu_or_BG" state to "BG" in order for monologue music to play
        AkSoundEngine.SetState("Monologue_or_Mrs_Thiru", "Monologue"); 

    }

    //Mrs Thiru
    public void MrsThiruMusic()
    {
        AkSoundEngine.SetState("Monologue_or_Mrs_Thiru", "Mrs_Thiru_mon");

       
        //choices
        //set the choice of music first before the set selected, don't know if it works differently in code but works that way in wwise
        //if choice "I'm sorry" is selected set state to hopeful
        AkSoundEngine.SetState("Mrs_Thiru_choices", "Hopeful");
        //if choice "Let's discuss" is selected set state to concerned
        AkSoundEngine.SetState("Mrs_Thiru_choices", "Concerned");
        //if choice "I don't really care" is selected set state to disappointed
        AkSoundEngine.SetState("Mrs_Thiru_choices", "Disappointed");
        //if a choice is not selected, will continue playing music until a choice is selected
        
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
        
        
    }

    public void HomeMusic()
    {

    }
}
