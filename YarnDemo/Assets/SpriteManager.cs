using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class SpriteManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Sprite;
    public Texture2D ThiruSurprisedS;
    public Texture2D ThiruConcernedS;
    public Texture2D ThiruDisappointedS;
    public Texture2D ThiruAmusedS;
    public Texture2D JamesTiredS;
    public Texture2D JamesDisappointedS;
    public Texture2D JamesWorriedS;
    public Texture2D JamesHopefulS;
    public Texture2D SitiHappyS;
    public Texture2D SitiAnnoyedS;
    public Texture2D SitiWorriedS;
    public Texture2D SitiHopefulS;
    public Texture2D PhoneTenseS;
    public Texture2D PhoneDullS;
    public Texture2D PhoneRelaxedS;
    public Texture2D PhoneHopefulS;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    [YarnCommand("ThiruSurprised")]
    public void ThiruSurprised() {
        
    }

    [YarnCommand("ThiruConcerned")]
    public void ThiruConcerned() {

    }

    [YarnCommand("ThiruDisappointed")]
    public void ThiruDisappointed() {

    }


    [YarnCommand("ThiruAmused")]
    public void ThiruAmused() {

    }

    [YarnCommand("JamesTired")]
    public void JamesTired() {

    }

    [YarnCommand("JamesWorried")]
    public void JamesWorried() {

    }

    [YarnCommand("JamesDisappointed")]
    public void JamesDisappointed() {

    }

    [YarnCommand("JamesHopeful")]
    public void JamesHopeful() {

    }

    [YarnCommand("SitiHappy")]
    public void SitiHappy() {

    }

    [YarnCommand("SitiAnnoyed")]
    public void SitiAnnoyed() {

    }

    [YarnCommand("SitiWorried")]
    public void SitiWorried() {

    }

    [YarnCommand("SitiHopeful")]
    public void SitiHopeful() {

    }

    [YarnCommand("PhoneTense")]
    public void PhoneTense() {

    }

    [YarnCommand("PhoneDull")]
    public void PhoneDull() {

    }

    [YarnCommand("PhoneRelaxed")]
    public void PhoneRelaxed() {

    }

    [YarnCommand("PhoneHopeful")]
    public void PhoneHopeful() {

    }
}
