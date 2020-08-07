using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class WwSoundManager : MonoBehaviour
{
    public GameObject SoundManager;
    //Yarn.Unity.DialogueUI DialogueUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    [YarnCommand("SchoolBell")]
    public void SchoolBell()
    {
        AkSoundEngine.PostEvent("School_Bell_Start", SoundManager); //plays school bell sound
    }

    //play when there's dialogue with parents
    [YarnCommand("Phone")]
    public void PhoneTyping()
    {
        //when player is talking to parents
        //need to set text speed to 0f (ignores text speed) in order for sound to be played correctly, otherwise audio will be sped up
        //DialogueUI = FindObjectOfType<Yarn.Unity.DialogueRunner>().GetComponent<DialogueUI>();
        //DialogueUI.textSpeed = 0f;
        AkSoundEngine.PostEvent("Phone_Typing_Start", SoundManager); //plays phone typing sound
        //stop sound when text isn't shown otherwise the sound will continue
    }

    [YarnCommand("PhoneStop")]
    public void PhoneTypingStop()
    {
        AkSoundEngine.PostEvent("Phone_Typing_Stop", SoundManager);
    }

    [YarnCommand("PhoneNotification")]
    public void PhoneNotification()
    {
        //when player receives msg from parents
        AkSoundEngine.PostEvent("Phone_Notification_Start", SoundManager); //plays phone notification sound
    }

    [YarnCommand("LivingRoom")]
    public void LivingRoomAmbience()
    {
        //if at home (living room), play living room ambience
        AkSoundEngine.PostEvent("Living_room", SoundManager); //plays living room ambience
    }

    [YarnCommand("StopLivingRoom")]
    public void StopLivingRoomAmbience()
    {
        AkSoundEngine.PostEvent("Living_room_stop", SoundManager); //stops playing living room ambience
    }

    [YarnCommand("StaffRoom")]
    public void StaffRoomAmbience()
    {
        //if at school (staff room)
        AkSoundEngine.PostEvent("Staff_room", SoundManager); //plays staff room ambience

    }

    [YarnCommand("StopStaffRoom")]
    public void StopStaffRoomAmbience()
    {
        AkSoundEngine.PostEvent("Staff_room_stop", SoundManager); // stops playing staff room ambience
    }

    [YarnCommand("Canteen")]
    public void CanteenAmbience()
    {
        //if at school (canteen)
        AkSoundEngine.PostEvent("Canteen", SoundManager); //plays canteen ambience

    }

    [YarnCommand("StopCanteen")]
    public void StopCanteenAmbience()
    {
        AkSoundEngine.PostEvent("Staff_room_stop", SoundManager); // stops playing staff room ambience
    }

    [YarnCommand("StopDialogue")]
    public void StopDialogueSound()
    {
        AkSoundEngine.PostEvent("Character_dialogue_stop", SoundManager); //stops dialogue sound
    }

    //refer to writer's script in docs
    //if James is tired
    [YarnCommand("JamesTired")]
    public void JamesTiredDialogue()
    {
        //need to set text speed to 0f (ignores text speed) in order for sound to be played correctly, otherwise audio will be sped up
        //DialogueUI = FindObjectOfType<Yarn.Unity.DialogueRunner>().GetComponent<DialogueUI>();
        //DialogueUI.textSpeed = 0f;

        //if James is speaking
        AkSoundEngine.SetSwitch("Characters", "James", SoundManager);

        AkSoundEngine.SetSwitch("James_emotion", "Tired", SoundManager);
        AkSoundEngine.PostEvent("Character_dialogue", SoundManager); //plays dialogue

    }


    //refer to writer's script in docs
    //if James is frustrated
    [YarnCommand("JamesFrustrated")]
    public void JamesFrustratedDialogue()
    {
        //need to set text speed to 0f (ignores text speed) in order for sound to be played correctly, otherwise audio will be sped up
        //DialogueUI = FindObjectOfType<Yarn.Unity.DialogueRunner>().GetComponent<DialogueUI>();
       // DialogueUI.textSpeed = 0f;

        //if James is speaking
        AkSoundEngine.SetSwitch("Characters", "James", SoundManager);

        AkSoundEngine.SetSwitch("James_emotion", "Frustrated", SoundManager);
        AkSoundEngine.PostEvent("Character_dialogue", SoundManager); //plays dialogue

    }


    //refer to writer's script in docs
    //if James is disappointed
    [YarnCommand("JamesDisappointed")]
    public void JamesDisappointedDialogue()
    {
        //need to set text speed to 0f (ignores text speed) in order for sound to be played correctly, otherwise audio will be sped up
        //DialogueUI = FindObjectOfType<Yarn.Unity.DialogueRunner>().GetComponent<DialogueUI>();
        //DialogueUI.textSpeed = 0f;

        //if James is speaking
        AkSoundEngine.SetSwitch("Characters", "James", SoundManager);

        AkSoundEngine.SetSwitch("James_emotion", "Disappointed", SoundManager);
        AkSoundEngine.PostEvent("Character_dialogue", SoundManager); //plays dialogue

    }


    //refer to writer's script in docs
    //if James is tired
    [YarnCommand("JamesHopeful")]
    public void JamesHopefulDialogue()
    {
        //need to set text speed to 0f (ignores text speed) in order for sound to be played correctly, otherwise audio will be sped up
        //DialogueUI = FindObjectOfType<Yarn.Unity.DialogueRunner>().GetComponent<DialogueUI>();
        //DialogueUI.textSpeed = 0f;

        //if James is speaking
        AkSoundEngine.SetSwitch("Characters", "James", SoundManager);

        AkSoundEngine.SetSwitch("James_emotion", "Hopeful", SoundManager);
        AkSoundEngine.PostEvent("Character_dialogue", SoundManager); //plays dialogue

    }


    //refer to writer's script in docs
    //if James is tired
    [YarnCommand("JamesWorried")]
    public void JamesWorriedDialogue()
    {
        //need to set text speed to 0f (ignores text speed) in order for sound to be played correctly, otherwise audio will be sped up
        //DialogueUI = FindObjectOfType<Yarn.Unity.DialogueRunner>().GetComponent<DialogueUI>();
        //DialogueUI.textSpeed = 0f;

        //if James is speaking
        AkSoundEngine.SetSwitch("Characters", "James", SoundManager);

        AkSoundEngine.SetSwitch("James_emotion", "Worried", SoundManager);
        AkSoundEngine.PostEvent("Character_dialogue", SoundManager); //plays dialogue

    }

    //refer to writer's script in docs
    //if Siti is happy
    [YarnCommand("SitiHappy")]
    public void SitiHappyDialogue()
    {
        //need to set text speed to 0f (ignores text speed) in order for sound to be played correctly, otherwise audio will be sped up
        //DialogueUI = FindObjectOfType<Yarn.Unity.DialogueRunner>().GetComponent<DialogueUI>();
        //DialogueUI.textSpeed = 0f;

        //if Siti is speaking
        AkSoundEngine.SetSwitch("Characters", "Siti", SoundManager);

        AkSoundEngine.SetSwitch("Siti_emotion", "Happy", SoundManager);
        AkSoundEngine.PostEvent("Character_dialogue", SoundManager); //plays dialogue

    }

    //refer to writer's script in docs
    //if Siti is hopeful
    [YarnCommand("SitiHopeful")]
    public void SitiHopefulDialogue()
    {
        //need to set text speed to 0f (ignores text speed) in order for sound to be played correctly, otherwise audio will be sped up
        //DialogueUI = FindObjectOfType<Yarn.Unity.DialogueRunner>().GetComponent<DialogueUI>();
        //DialogueUI.textSpeed = 0f;

        //if Siti is speaking
        AkSoundEngine.SetSwitch("Characters", "Siti", SoundManager);

        AkSoundEngine.SetSwitch("Siti_emotion", "Hopeful", SoundManager);
        AkSoundEngine.PostEvent("Character_dialogue", SoundManager); //plays dialogue

    }

    //refer to writer's script in docs
    //if Siti is annoyed
    [YarnCommand("SitiAnnoyed")]
    public void SitiAnnoyedDialogue()
    {
        //need to set text speed to 0f (ignores text speed) in order for sound to be played correctly, otherwise audio will be sped up
        //DialogueUI = FindObjectOfType<Yarn.Unity.DialogueRunner>().GetComponent<DialogueUI>();
       // DialogueUI.textSpeed = 0f;

        //if Siti is speaking
        AkSoundEngine.SetSwitch("Characters", "Siti", SoundManager);

        AkSoundEngine.SetSwitch("Siti_emotion", "Annoyed", SoundManager);
        AkSoundEngine.PostEvent("Character_dialogue", SoundManager); //plays dialogue

    }

    //refer to writer's script in docs
    //if Siti is happy
    [YarnCommand("SitiWorried")]
    public void SitiWorriedDialogue()
    {
        //need to set text speed to 0f (ignores text speed) in order for sound to be played correctly, otherwise audio will be sped up
       // DialogueUI = FindObjectOfType<Yarn.Unity.DialogueRunner>().GetComponent<DialogueUI>();
       // DialogueUI.textSpeed = 0f;

        //if Siti is speaking
        AkSoundEngine.SetSwitch("Characters", "Siti", SoundManager);

        AkSoundEngine.SetSwitch("Siti_emotion", "Worried", SoundManager);
        AkSoundEngine.PostEvent("Character_dialogue", SoundManager); //plays dialogue

    }

    //refer to writer's script in docs
    //if Mrs Thiru is disappointed
    [YarnCommand("MrsThiruDisappointed")]
    public void MrsThiruDisappointedialogue()
    {
        //need to set text speed to 0f (ignores text speed) in order for sound to be played correctly, otherwise audio will be sped up
        //DialogueUI = FindObjectOfType<Yarn.Unity.DialogueRunner>().GetComponent<DialogueUI>();
       // DialogueUI.textSpeed = 0f;

        //if Siti is speaking
        AkSoundEngine.SetSwitch("Characters", "Mrs_Thiru", SoundManager);

        AkSoundEngine.SetSwitch("Mrs_Thiru_emotion", "Disappointed", gameObject);
        AkSoundEngine.PostEvent("Character_dialogue", SoundManager); //plays dialogue

    }

    //refer to writer's script in docs
    //if Mrs Thiru is concerned
    [YarnCommand("MrsThiruConcerned")]
    public void MrsThiruConcernedDialogue()
    {
        //need to set text speed to 0f (ignores text speed) in order for sound to be played correctly, otherwise audio will be sped up
       // DialogueUI = FindObjectOfType<Yarn.Unity.DialogueRunner>().GetComponent<DialogueUI>();
        //DialogueUI.textSpeed = 0f;

        //if Siti is speaking
        AkSoundEngine.SetSwitch("Characters", "Mrs_Thiru", SoundManager);

        AkSoundEngine.SetSwitch("Mrs_Thiru_emotion", "Concerned", SoundManager);
        AkSoundEngine.PostEvent("Character_dialogue", SoundManager); //plays dialogue

    }

    //refer to writer's script in docs
    //if Mrs Thiru is surprised
    [YarnCommand("MrsThiruSurprised")]
    public void MrsThiruSurprisedialogue()
    {
        //need to set text speed to 0f (ignores text speed) in order for sound to be played correctly, otherwise audio will be sped up
       // DialogueUI = FindObjectOfType<Yarn.Unity.DialogueRunner>().GetComponent<DialogueUI>();
       // DialogueUI.textSpeed = 0f;

        //if Siti is speaking
        AkSoundEngine.SetSwitch("Characters", "Mrs_Thiru", SoundManager);

        AkSoundEngine.SetSwitch("Mrs_Thiru_emotion", "Surprised", SoundManager);
        AkSoundEngine.PostEvent("Character_dialogue", gameObject); //plays dialogue

    }

    //refer to writer's script in docs
    //if Mrs Thiru is amused
    [YarnCommand("MrsThiruAmused")]
    public void MrsThiruAmusedialogue()
    {
        //need to set text speed to 0f (ignores text speed) in order for sound to be played correctly, otherwise audio will be sped up
        //DialogueUI = FindObjectOfType<Yarn.Unity.DialogueRunner>().GetComponent<DialogueUI>();
        //DialogueUI.textSpeed = 0f;

        //if Siti is speaking
        AkSoundEngine.SetSwitch("Characters", "Mrs_Thiru", SoundManager);

        AkSoundEngine.SetSwitch("Mrs_Thiru_emotion", "Amused", SoundManager);
        AkSoundEngine.PostEvent("Character_dialogue", SoundManager); //plays dialogue

    }

}
