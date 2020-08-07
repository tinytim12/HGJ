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

    public void SchoolBell()
    {
        AkSoundEngine.PostEvent("School_Bell_Start", SoundManager); //plays school bell sound
    }

    //play when there's dialogue with parents 
    public void PhoneTyping()
    {
        //when player is talking to parents
        //need to set text speed to 0f (ignores text speed) in order for sound to be played correctly, otherwise audio will be sped up
        //DialogueUI = FindObjectOfType<Yarn.Unity.DialogueRunner>().GetComponent<DialogueUI>();
        //DialogueUI.textSpeed = 0f;
        AkSoundEngine.PostEvent("Phone_Typing_Start", SoundManager); //plays phone typing sound
        //stop sound when text isn't shown otherwise the sound will continue
    }

    public void PhoneNotification()
    {
        //when player receives msg from parents
        AkSoundEngine.PostEvent("Phone_Notification_Start", SoundManager); //plays phone notification sound
    }

    public void LivingRoomAmbience()
    {
        //if at home (living room), play living room ambience
        AkSoundEngine.PostEvent("Living_room", SoundManager); //plays living room ambience
    }

    public void StopLivingRoomAmbience()
    {
        AkSoundEngine.PostEvent("Living_room_stop", SoundManager); //stops playing living room ambience
    }

    public void StaffRoomAmbience()
    {
        //if at school (staff room)
        AkSoundEngine.PostEvent("Staff_room", SoundManager); //plays staff room ambience

    }

    public void StopStaffRoomAmbience()
    {
        AkSoundEngine.PostEvent("Staff_room_stop", SoundManager); // stops playing staff room ambience
    }

    public void CanteenAmbience()
    {
        //if at school (canteen)
        AkSoundEngine.PostEvent("Canteen", SoundManager); //plays canteen ambience

    }

    public void StopCanteenAmbience()
    {
        AkSoundEngine.PostEvent("Staff_room_stop", SoundManager); // stops playing staff room ambience
    }

    public void StopDialogueSound()
    {
        AkSoundEngine.PostEvent("Character_dialogue_stop", SoundManager); //stops dialogue sound
    }

    //refer to writer's script in docs
    //if James is tired
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
