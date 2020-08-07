using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class WwMusicManager : MonoBehaviour
{
    public GameObject MusicManager;
    // Start is called before the first frame update
    void Start()
    {

    }
     

    // Update is called once per frame
    void Update()
    {
       
    }

    public void MainMenuMusic()
    {
        AkSoundEngine.SetState("Menu_or_BG", "Menu"); // sets it to menu
        AkSoundEngine.PostEvent("Menu_music", MusicManager);

    }

    public void MonologueMusic()
    {
        AkSoundEngine.SetState("Menu_or_BG", "BG");
        AkSoundEngine.SetState("Monologue_or_Mrs_Thiru", "Monologue");
    }

    public void BGMusic()
    {
        AkSoundEngine.SetState("Menu_or_BG", "BG");
        AkSoundEngine.PostEvent("BG_music", MusicManager);
    }

    public void BGMusicStop()
    {
        AkSoundEngine.SetState("Menu_or_BG", "BG");
        AkSoundEngine.PostEvent("BG_music_stop", MusicManager);
    }
    //Mrs Thiru
    public void MrsThiruMusicDay1()
    {
        //day 1
        AkSoundEngine.SetState("Days", "Day_1");
        AkSoundEngine.SetState("Monologue_or_Mrs_Thiru", "Mrs_Thiru");
        BGMusic();
   
    }

    //mrs thiru options
    //choice: "I'm sorry"
    public void MrsThiruChoiceSorry()
    {
        AkSoundEngine.SetState("Days", "Day_1");
        AkSoundEngine.SetState("Monologue_or_Mrs_Thiru", "Mrs_Thiru");
        AkSoundEngine.SetState("Mrs_Thiru_choices", "Hopeful");
        BGMusic();
    }

    //choice: "Let's discuss
    public void MrsThiruDiscuss()
    {
        AkSoundEngine.SetState("Days", "Day_1");
        AkSoundEngine.SetState("Monologue_or_Mrs_Thiru", "Mrs_Thiru");
        AkSoundEngine.SetState("Mrs_Thiru_choices", "Concerned");
        BGMusic();
    }

    //choice: "I don't really care
    public void MrsThiruDontCare()
    {
        AkSoundEngine.SetState("Menu_or_BG", "BG");
        AkSoundEngine.SetState("Days", "Day_1");
        AkSoundEngine.SetState("Monologue_or_Mrs_Thiru", "Mrs_Thiru");
        AkSoundEngine.SetState("Mrs_Thiru_choices", "Disappointed");
    }

    //James day 1
    public void JamesMusicDay1()
    {
        AkSoundEngine.SetState("Days", "Day_1");
        AkSoundEngine.SetState("James_or_Siti", "James");
        BGMusic();
    }

    //james choice: "actually I do"
    public void JamesMoney()
    {
        AkSoundEngine.SetState("Days", "Day_1");
        AkSoundEngine.SetState("James_choices", "Hopeful");
    }

    //james choice: "I'm sorry, I don't"
    public void JamesNoMoney()
    {
        AkSoundEngine.SetState("Days", "Day_1");
        AkSoundEngine.SetState("James_choices", "Disappointed");
    }

    //Siti day 1

}
