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

    }

    public void MonologueMusic()
    {
        AkSoundEngine.SetState("Menu_or_BG", "BG");
        AkSoundEngine.SetState("Monologue_or_Mrs_Thiru", "Monologue");
    }

    //Mrs Thiru
    public void MrsThiruMusicDay1()
    {
        //day 1
        AkSoundEngine.SetState("Menu_or_BG", "BG");
        AkSoundEngine.SetState("Days", "Day_1");
        AkSoundEngine.SetState("Monologue_or_Mrs_Thiru", "Mrs_Thiru");
   
    }

    //mrs thiru options
    //choice: "I'm sorry"
    public void MrsThiruChoiceSorry()
    {
        AkSoundEngine.SetState("Menu_or_BG", "BG");
        AkSoundEngine.SetState("Days", "Day_1");
        AkSoundEngine.SetState("Monologue_or_Mrs_Thiru", "Mrs_Thiru");
        AkSoundEngine.SetState("Mrs_Thiru_choices", "Hopeful");
    }

    //choice: "Let's discuss
    public void MrsThiruDiscuss()
    {
        AkSoundEngine.SetState("Menu_or_BG", "BG");
        AkSoundEngine.SetState("Days", "Day_1");
        AkSoundEngine.SetState("Monologue_or_Mrs_Thiru", "Mrs_Thiru");
        AkSoundEngine.SetState("Mrs_Thiru_choices", "Concerned");
    }

    //choice: "I don't really care
    public void MrsThiruDontCare()
    {
        AkSoundEngine.SetState("Menu_or_BG", "BG");
        AkSoundEngine.SetState("Days", "Day_1");
        AkSoundEngine.SetState("Monologue_or_Mrs_Thiru", "Mrs_Thiru");
        AkSoundEngine.SetState("Mrs_Thiru_choices", "Disappointed");
    }
}
