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

    [YarnCommand("MainMenu")]
    public void MainMenuMusic()
    {
        AkSoundEngine.SetState("Menu_or_BG", "Menu"); // sets it to menu
        AkSoundEngine.PostEvent("Menu_music", MusicManager);

    }

    [YarnCommand("Monologue")]
    public void MonologueMusic()
    {
        AkSoundEngine.SetState("Menu_or_BG", "BG");
        AkSoundEngine.SetState("Monologue_or_Mrs_Thiru", "Monologue");
    }

    [YarnCommand("BG")]
    public void BGMusic()
    {
        AkSoundEngine.SetState("Menu_or_BG", "BG");
        AkSoundEngine.PostEvent("BG_music", MusicManager);
    }

    [YarnCommand("BGStop")]
    public void BGMusicStop()
    {
        AkSoundEngine.SetState("Menu_or_BG", "BG");
        AkSoundEngine.PostEvent("BG_music_stop", MusicManager);
    }
    //Mrs Thiru

    [YarnCommand("MrsThiruDay1")]
    public void MrsThiruMusicDay1()
    {
        //day 1
        AkSoundEngine.SetState("Days", "Day_1");
        AkSoundEngine.SetState("Monologue_or_Mrs_Thiru", "Mrs_Thiru");
        BGMusic();
   
    }

    public void MrsThiruMusicDay2()
    {
        //day 1
        AkSoundEngine.SetState("Days", "Day_2");
        AkSoundEngine.SetState("Monologue_or_Mrs_Thiru", "Mrs_Thiru");
        BGMusic();

    }

    //mrs thiru options
    //choice: "I'm sorry"
    [YarnCommand("MrsThiruSorry")]
    public void MrsThiruChoiceSorry()
    {
        AkSoundEngine.SetState("Days", "Day_1");
        AkSoundEngine.SetState("Monologue_or_Mrs_Thiru", "Mrs_Thiru");
        AkSoundEngine.SetState("Mrs_Thiru_choices", "Hopeful");
        BGMusic();
    }

    //choice: "Let's discuss
    [YarnCommand("MrsThiruDiscuss")]
    public void MrsThiruDiscuss()
    {
        AkSoundEngine.SetState("Days", "Day_1");
        AkSoundEngine.SetState("Monologue_or_Mrs_Thiru", "Mrs_Thiru");
        AkSoundEngine.SetState("Mrs_Thiru_choices", "Concerned");
        BGMusic();
    }

    //choice: "I don't really care
    [YarnCommand("MrsThiruDontCare")]
    public void MrsThiruDontCare()
    {
        AkSoundEngine.SetState("Menu_or_BG", "BG");
        AkSoundEngine.SetState("Days", "Day_1");
        AkSoundEngine.SetState("Monologue_or_Mrs_Thiru", "Mrs_Thiru");
        AkSoundEngine.SetState("Mrs_Thiru_choices", "Disappointed");
    }

    //James day 1
    [YarnCommand("JamesDay1")]
    public void JamesMusicDay1()
    {
        AkSoundEngine.SetState("James_or_Siti", "James");
        AkSoundEngine.SetState("Days", "Day_1");
        BGMusic();

    }

    //James day 2
    [YarnCommand("JamesDay2")]
    public void JamesMusicDay2()
    {
        AkSoundEngine.SetState("James_or_Siti", "James");
        AkSoundEngine.SetState("Days", "Day_2");
        BGMusic();
        
    }
    //james day 3
    [YarnCommand("JamesDay3")]
    public void JamesMusicDay3()
    {
        AkSoundEngine.SetState("James_or_Siti", "James");
        AkSoundEngine.SetState("Days", "Day_3");
        BGMusic();

    }

    //james choice: "actually I do" - day 1
    //james choice: "keep studying" - day 3
    //day 3 - (work) "maybe studying" 
    [YarnCommand("JamesHopeful")]
    public void JamesHopeful()
    {
        AkSoundEngine.SetState("James_choices", "Hopeful");
        BGMusic();
    }

    //james choice: "I'm sorry, I don't"
    //james choice: "yeah, about your dad" (no time to write music for worried, just use this)
    [YarnCommand("JamesDisappointed")]
    public void JamesDisappointed()
    {
        AkSoundEngine.SetState("James_choices", "Disappointed");
        BGMusic();
    }

    //day 2 - "work"
    [YarnCommand("JamesTired")]
    public void JamesTired()
    {
        AkSoundEngine.SetState("James_choices", "Tired");
        BGMusic();
    }

    //day 2 - study
    //day 3 - (work) "gotta keep studying"
    [YarnCommand("JamesFrustrated")]
    public void JamesFrustrated()
    {
        AkSoundEngine.SetState("James_choices", "Frustrated");
        BGMusic();
    }

    //Siti day 1
    [YarnCommand("SitiDay1")]
    public void SitiMusicDay1()
    {
        AkSoundEngine.SetState("James_or_Siti", "Siti");
        AkSoundEngine.SetState("Days", "Day_1");
        BGMusic();

    }

    //James day 2
    [YarnCommand("SitiDay2")]
    public void SitiMusicDay2()
    {
        AkSoundEngine.SetState("James_or_Siti", "Siti");
        AkSoundEngine.SetState("Days", "Day_2");
        BGMusic();

    }
    //james day 3
    [YarnCommand("SitiDay3")]
    public void SitiMusicDay3()
    {
        AkSoundEngine.SetState("James_or_Siti", "Siti");
        AkSoundEngine.SetState("Days", "Day_3");
        BGMusic();

    }

    //siti choice "I'm interested" day 1
    //day 3 (drop) relaxed just use happy (not time to write music for it)
    [YarnCommand("SitiHappy")]
    public void SitiHappy()
    {
        AkSoundEngine.SetState("Siti_choices", "Happy");
        BGMusic();
    }

    //day 1 - "no sorry"
    //day 2 - "follow.."
    //day 3 - (continue) "you must be really tired"
    //day 3 - (drop) "I hope someone changes..."
    [YarnCommand("SitiHopeful")]
    public void SitiHopeful()
    {
        AkSoundEngine.SetState("Siti_choices", "Hopeful");
        BGMusic();
    }

    //day 2 - "bear with it"
    //day 3 - (continue) annoyed
    [YarnCommand("SitiAnnoyed")]
    public void SitiAnnoyed()
    {
        AkSoundEngine.SetState("Siti_choices", "Annoyed");
        BGMusic();
    }

    //home music

    //day 1 "submit"
    //day 3 if confident, prepared: dull
    [YarnCommand("HomeDull")]
    public void HomeDull()
    {
        AkSoundEngine.SetState("Home", "Home");
        AkSoundEngine.SetState("Home_choices", "Dull");
        BGMusic();
    }

    //day 1 "stand your ground" & "negotiate"
    //day 2 "stand your ground", "not really prepared, "confide"
    //day 3 if confident; didn't prepare, if defeated; didn't prepare,
    [YarnCommand("HomeTense")]
    public void HomeTense()
    {
        AkSoundEngine.SetState("Home", "Home");
        AkSoundEngine.SetState("Home_choices", "Tense");
        BGMusic();
    }

    //day 2 "apologise", "quite prepared", "too tired"
    [YarnCommand("HomeRelaxed")]
    public void HomeRelaxed()
    {
        AkSoundEngine.SetState("Home", "Home");
        AkSoundEngine.SetState("Home_choices", "Relaxed");
        BGMusic();
    }

    //day 3 if defeatd, prepared
    [YarnCommand("HomeHopeful")]
    public void HomeHopeful()
    {
        AkSoundEngine.SetState("Home", "Home");
        AkSoundEngine.SetState("Home_choices", "Hopeful");
        BGMusic();
    }

    //homework mini game

    //if player got 1m
    [YarnCommand("MiniGameZen")]
    public void MiniGameZen()
    {
        AkSoundEngine.SetState("Homework_mini_game", "Zen");
    }

    //if player got 30s
    [YarnCommand("MiniGameTense")]
    public void MiniGameTense()
    {
        AkSoundEngine.SetState("Homework_mini_game", "Tense");
    }

    //if player got 15s
    [YarnCommand("MiniGameRushed")]
    public void MiniGameRushed()
    {
        AkSoundEngine.SetState("Homework_mini_game", "Rushed");
    }
}
