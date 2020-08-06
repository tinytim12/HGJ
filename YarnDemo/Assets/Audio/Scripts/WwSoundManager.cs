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

    public void PhoneSFX()
    {
        //when player receives msg from parents
        AkSoundEngine.PostEvent("Phone_Notification_Start", gameObject); //plays phone notification sound
        //when player is talking to parents
        //need to set text speed to 0f (ignores text speed) in order for sound to be played correctly, otherwise audio will be sped up
        DialogueUI = FindObjectOfType<Yarn.Unity.DialogueRunner>().GetComponent<DialogueUI>();
        DialogueUI.textSpeed = 0f;
        AkSoundEngine.PostEvent("Phone_Typing_Start", gameObject); //plays phone typing sound
        //stop sound when text isn't shown otherwise the sound will continue
        AkSoundEngine.PostEvent("Phone_Typing_Stop", gameObject); //stops phone typing sound
    }

    public void Ambience()
    {
        //if at home (living room), play living room ambience
        AkSoundEngine.PostEvent("Living_room", gameObject); //plays living room ambience
        AkSoundEngine.PostEvent("Living_room_stop", gameObject); //stops playing living room ambience

        //if at school (staff room)
        AkSoundEngine.PostEvent("Staff_room", gameObject); //plays staff room ambience
        AkSoundEngine.PostEvent("Staff_room_stop", gameObject); // stops playing staff room ambience

        //if at school (canteen)
        AkSoundEngine.PostEvent("Canteen", gameObject); //plays canteen ambience
        AkSoundEngine.PostEvent("Canteen_stop", gameObject); //stops canteen ambience
    }

    public void VoiceDialogue()
    {
        //need to set text speed to 0f (ignores text speed) in order for sound to be played correctly, otherwise audio will be sped up
        DialogueUI = FindObjectOfType<Yarn.Unity.DialogueRunner>().GetComponent<DialogueUI>();
        DialogueUI.textSpeed = 0f;

        //set character switch to Character first, then the emotion switch, then post event
        //set the switch first before post event
        //need to post event in order to play the sound 
        //if Siti, James or Mrs Thiru is speaking
        AkSoundEngine.PostEvent("Character_dialogue", gameObject); //plays dialogue
        //if James is speaking
        AkSoundEngine.SetSwitch("Characters", "James", gameObject);
        //if Siti is speaking
        AkSoundEngine.SetSwitch("Characters", "Siti", gameObject);
        //if Mrs Thiru is speaking
        AkSoundEngine.SetSwitch("Characters", "Mrs_Thiru", gameObject);

        //refer to writer's script in docs
        //if James is tired
        AkSoundEngine.SetSwitch("James_emotion", "Tired", gameObject);
        //if James is disappointed
        AkSoundEngine.SetSwitch("James_emotion", "Disappointed", gameObject);
        //if James is hopeful
        AkSoundEngine.SetSwitch("James_emotion", "Hopeful", gameObject);
        //if James is worried
        AkSoundEngine.SetSwitch("James_emotion", "Worried", gameObject);
        //if James is frustrated
        AkSoundEngine.SetSwitch("James_emotion", "Frustrated", gameObject);

        //if Siti is happy
        AkSoundEngine.SetSwitch("Siti_emotion", "Happy", gameObject);
        //if Siti is hopeful
        AkSoundEngine.SetSwitch("Siti_emotion", "Hopeful", gameObject);
        //if Siti is annoyed
        AkSoundEngine.SetSwitch("Siti_emotion", "Annoyed", gameObject);
        //if Siti is worried
        AkSoundEngine.SetSwitch("Siti_emotion", "Worried", gameObject);

        //if Mrs Thiru is disappointed
        AkSoundEngine.SetSwitch("Mrs_Thiru_emotion", "Disappointed", gameObject);
        //if Mrs Thiru is concerned
        AkSoundEngine.SetSwitch("Mrs_Thiru_emotion", "Concerned", gameObject);
        //if Mrs Thiru is surprised
        AkSoundEngine.SetSwitch("Mrs_Thiru_emotion", "Surprised", gameObject);
        //if Mrs Thiru is amused
        AkSoundEngine.SetSwitch("Mrs_Thiru_emotion", "Amused", gameObject);
    }
}
