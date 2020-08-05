using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class WwSoundManager : MonoBehaviour
{

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
        
    }
}
