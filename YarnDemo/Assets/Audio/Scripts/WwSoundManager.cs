using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class WwSoundManager : MonoBehaviour
{
    Yarn.Unity.DialogueUI DialogueUI;
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
        AkSoundEngine.PostEvent("School_Bell_Start", gameObject); //plays school bell sound
    }

    //play when there's dialogue with parents
    [YarnCommand("PhoneTyping")]
    public void PhoneTyping()
    {
        //when player is talking to parents
        //need to set text speed to 0f (ignores text speed) in order for sound to be played correctly, otherwise audio will be sped up
        DialogueUI = FindObjectOfType<Yarn.Unity.DialogueRunner>().GetComponent<DialogueUI>();
        DialogueUI.textSpeed = 0f;
        AkSoundEngine.PostEvent("Phone_Typing_Start", gameObject); //plays phone typing sound
        //stop sound when text isn't shown otherwise the sound will continue
    }

    [YarnCommand("PhoneNotification")]
    public void PhoneNotification()
    {
        //when player receives msg from parents
        AkSoundEngine.PostEvent("Phone_Notification_Start", gameObject); //plays phone notification sound
    }

    [YarnCommand("LivingRoomAmbience")]
    public void LivingRoomAmbience()
    {
        //if at home (living room), play living room ambience
        AkSoundEngine.PostEvent("Living_room", gameObject); //plays living room ambience
        AkSoundEngine.PostEvent("Living_room_stop", gameObject); //stops playing living room ambience
    }

    [YarnCommand("StaffRoomAmbience")]
    public void StaffRoomAmbience()
    {
        //if at school (staff room)
        AkSoundEngine.PostEvent("Staff_room", gameObject); //plays staff room ambience
        AkSoundEngine.PostEvent("Staff_room_stop", gameObject); // stops playing staff room ambience

    }

    [YarnCommand("CanteenAmbience")]
    public void CanteenAmbience()
    {
        //if at school (canteen)
        AkSoundEngine.PostEvent("Canteen", gameObject); //plays canteen ambience
        AkSoundEngine.PostEvent("Canteen_stop", gameObject); //stops canteen ambience

    }

    //refer to writer's script in docs
    [YarnCommand("JamesTired")]
    //if James is tired
    public void JamesTiredDialogue()
    {
        //need to set text speed to 0f (ignores text speed) in order for sound to be played correctly, otherwise audio will be sped up
        DialogueUI = FindObjectOfType<Yarn.Unity.DialogueRunner>().GetComponent<DialogueUI>();
        DialogueUI.textSpeed = 0f;

        //if James is speaking
        AkSoundEngine.SetSwitch("Characters", "James", gameObject);

        AkSoundEngine.SetSwitch("James_emotion", "Tired", gameObject);
        AkSoundEngine.PostEvent("Character_dialogue", gameObject); //plays dialogue

    }


    //refer to writer's script in docs
    //if James is frustrated
    [YarnCommand("JamesFrustrated")]
    public void JamesFrustratedDialogue()
    {
        //need to set text speed to 0f (ignores text speed) in order for sound to be played correctly, otherwise audio will be sped up
        DialogueUI = FindObjectOfType<Yarn.Unity.DialogueRunner>().GetComponent<DialogueUI>();
        DialogueUI.textSpeed = 0f;

        //if James is speaking
        AkSoundEngine.SetSwitch("Characters", "James", gameObject);

        AkSoundEngine.SetSwitch("James_emotion", "Frustrated", gameObject);
        AkSoundEngine.PostEvent("Character_dialogue", gameObject); //plays dialogue

    }


    //refer to writer's script in docs
    //if James is disappointed
    [YarnCommand("JamesDisappointed")]
    public void JamesDisappointedDialogue()
    {
        //need to set text speed to 0f (ignores text speed) in order for sound to be played correctly, otherwise audio will be sped up
        DialogueUI = FindObjectOfType<Yarn.Unity.DialogueRunner>().GetComponent<DialogueUI>();
        DialogueUI.textSpeed = 0f;

        //if James is speaking
        AkSoundEngine.SetSwitch("Characters", "James", gameObject);

        AkSoundEngine.SetSwitch("James_emotion", "Disappointed", gameObject);
        AkSoundEngine.PostEvent("Character_dialogue", gameObject); //plays dialogue

    }


    //refer to writer's script 
    //if James is tired
    [YarnCommand("JamesHopeful")]
    public void JamesHopefulDialogue()
    {
        //need to set text speed to 0f (ignores text speed) in order for sound to be played correctly, otherwise audio will be sped up
        DialogueUI = FindObjectOfType<Yarn.Unity.DialogueRunner>().GetComponent<DialogueUI>();
        DialogueUI.textSpeed = 0f;

        //if James is speaking
        AkSoundEngine.SetSwitch("Characters", "James", gameObject);

        AkSoundEngine.SetSwitch("James_emotion", "Hopeful", gameObject);
        AkSoundEngine.PostEvent("Character_dialogue", gameObject); //plays dialogue

    }


    //refer to writer's script in docs
    //if James is tired
    [YarnCommand("JamesWorried")]
    public void JamesWorriedDialogue()
    {
        //need to set text speed to 0f (ignores text speed) in order for sound to be played correctly, otherwise audio will be sped up
        DialogueUI = FindObjectOfType<Yarn.Unity.DialogueRunner>().GetComponent<DialogueUI>();
        DialogueUI.textSpeed = 0f;

        //if James is speaking
        AkSoundEngine.SetSwitch("Characters", "James", gameObject);

        AkSoundEngine.SetSwitch("James_emotion", "Worried", gameObject);
        AkSoundEngine.PostEvent("Character_dialogue", gameObject); //plays dialogue

    }

    //refer to writer's script in docs
    //if Siti is happy
    [YarnCommand("SitiHappy")]
    public void SitiHappyDialogue()
    {
        //need to set text speed to 0f (ignores text speed) in order for sound to be played correctly, otherwise audio will be sped up
        DialogueUI = FindObjectOfType<Yarn.Unity.DialogueRunner>().GetComponent<DialogueUI>();
        DialogueUI.textSpeed = 0f;

        //if Siti is speaking
        AkSoundEngine.SetSwitch("Characters", "Siti", gameObject);

        AkSoundEngine.SetSwitch("Siti_emotion", "Happy", gameObject);
        AkSoundEngine.PostEvent("Character_dialogue", gameObject); //plays dialogue

    }

    //refer to writer's script in docs
    //if Siti is hopeful
    [YarnCommand("SitiHopeful")]
    public void SitiHopefulDialogue()
    {
        //need to set text speed to 0f (ignores text speed) in order for sound to be played correctly, otherwise audio will be sped up
        DialogueUI = FindObjectOfType<Yarn.Unity.DialogueRunner>().GetComponent<DialogueUI>();
        DialogueUI.textSpeed = 0f;

        //if Siti is speaking
        AkSoundEngine.SetSwitch("Characters", "Siti", gameObject);

        AkSoundEngine.SetSwitch("Siti_emotion", "Hopeful", gameObject);
        AkSoundEngine.PostEvent("Character_dialogue", gameObject); //plays dialogue

    }

    //refer to writer's script in docs
    //if Siti is annoyed
    [YarnCommand("SitiAnnoyed")]
    public void SitiAnnoyedDialogue()
    {
        //need to set text speed to 0f (ignores text speed) in order for sound to be played correctly, otherwise audio will be sped up
        DialogueUI = FindObjectOfType<Yarn.Unity.DialogueRunner>().GetComponent<DialogueUI>();
        DialogueUI.textSpeed = 0f;

        //if Siti is speaking
        AkSoundEngine.SetSwitch("Characters", "Siti", gameObject);

        AkSoundEngine.SetSwitch("Siti_emotion", "Annoyed", gameObject);
        AkSoundEngine.PostEvent("Character_dialogue", gameObject); //plays dialogue

    }

    //refer to writer's script in docs
    //if Siti is happy
    [YarnCommand("SitiWorried")]
    public void SitiWorriedDialogue()
    {
        //need to set text speed to 0f (ignores text speed) in order for sound to be played correctly, otherwise audio will be sped up
        DialogueUI = FindObjectOfType<Yarn.Unity.DialogueRunner>().GetComponent<DialogueUI>();
        DialogueUI.textSpeed = 0f;

        //if Siti is speaking
        AkSoundEngine.SetSwitch("Characters", "Siti", gameObject);

        AkSoundEngine.SetSwitch("Siti_emotion", "Worried", gameObject);
        AkSoundEngine.PostEvent("Character_dialogue", gameObject); //plays dialogue

    }

    //refer to writer's script in docs
    //if Mrs Thiru is disappointed
    [YarnCommand("ThiruDisappointed")]
    public void MrsThiruDisappointedialogue()
    {
        //need to set text speed to 0f (ignores text speed) in order for sound to be played correctly, otherwise audio will be sped up
        DialogueUI = FindObjectOfType<Yarn.Unity.DialogueRunner>().GetComponent<DialogueUI>();
        DialogueUI.textSpeed = 0f;

        //if Siti is speaking
        AkSoundEngine.SetSwitch("Characters", "Mrs_Thiru", gameObject);

        AkSoundEngine.SetSwitch("Mrs_Thiru_emotion", "Disappointed", gameObject);
        AkSoundEngine.PostEvent("Character_dialogue", gameObject); //plays dialogue

    }

    //refer to writer's script in docs
    //if Mrs Thiru is concerned
    [YarnCommand("ThiruConcerned")]
    public void MrsThiruConcernedDialogue()
    {
        //need to set text speed to 0f (ignores text speed) in order for sound to be played correctly, otherwise audio will be sped up
        DialogueUI = FindObjectOfType<Yarn.Unity.DialogueRunner>().GetComponent<DialogueUI>();
        DialogueUI.textSpeed = 0f;

        //if Siti is speaking
        AkSoundEngine.SetSwitch("Characters", "Mrs_Thiru", gameObject);

        AkSoundEngine.SetSwitch("Mrs_Thiru_emotion", "Concerned", gameObject);
        AkSoundEngine.PostEvent("Character_dialogue", gameObject); //plays dialogue

    }

    //refer to writer's script in docs
    //if Mrs Thiru is surprised
    [YarnCommand("ThiruSurprised")]
    public void MrsThiruSurprisedialogue()
    {
        //need to set text speed to 0f (ignores text speed) in order for sound to be played correctly, otherwise audio will be sped up
        DialogueUI = FindObjectOfType<Yarn.Unity.DialogueRunner>().GetComponent<DialogueUI>();
        DialogueUI.textSpeed = 0f;

        //if Siti is speaking
        AkSoundEngine.SetSwitch("Characters", "Mrs_Thiru", gameObject);

        AkSoundEngine.SetSwitch("Mrs_Thiru_emotion", "Surprised", gameObject);
        AkSoundEngine.PostEvent("Character_dialogue", gameObject); //plays dialogue

    }

    //refer to writer's script in docs
    //if Mrs Thiru is amused
    [YarnCommand("ThiruAmused")]
    public void MrsThiruAmusedialogue()
    {
        //need to set text speed to 0f (ignores text speed) in order for sound to be played correctly, otherwise audio will be sped up
        DialogueUI = FindObjectOfType<Yarn.Unity.DialogueRunner>().GetComponent<DialogueUI>();
        DialogueUI.textSpeed = 0f;

        //if Siti is speaking
        AkSoundEngine.SetSwitch("Characters", "Mrs_Thiru", gameObject);

        AkSoundEngine.SetSwitch("Mrs_Thiru_emotion", "Amused", gameObject);
        AkSoundEngine.PostEvent("Character_dialogue", gameObject); //plays dialogue

    }

}
