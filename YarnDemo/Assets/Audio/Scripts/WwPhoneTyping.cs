using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class WwPhoneTyping : MonoBehaviour
{
    public string PhoneStart = "Phone_Typing_Start";
    public string PhoneStop = "Phone_Typing_Stop";

    Yarn.Unity.DialogueUI DialogueUI;

    [YarnCommand("phoneTyping")]
    public void PhoneTyping()
    {
        AkSoundEngine.PostEvent(PhoneStart, gameObject);
        DialogueUI = FindObjectOfType<Yarn.Unity.DialogueRunner>().GetComponent<DialogueUI>();
        DialogueUI.textSpeed = 0f;
        
    }

    [YarnCommand("phoneTypingStop")]
    public void PhoneTypingStop()
    {
        AkSoundEngine.PostEvent(PhoneStop, gameObject);
    }
}
