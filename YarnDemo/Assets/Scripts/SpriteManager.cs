using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class SpriteManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Sprite;
    public Sprite ThiruSurprisedS;
    public Sprite ThiruConcernedS;
    public Sprite ThiruDisappointedS;
    public Sprite ThiruAmusedS;
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

    public SpriteRenderer spriteRenderer;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [YarnCommand("NoSprite")]
    public void NoSprite() {
        spriteRenderer.sprite = null;
    }

    [YarnCommand("ThiruSurprised")]
    public void ThiruSurprised() {
        spriteRenderer.sprite = ThiruSurprisedS;
    }

    [YarnCommand("ThiruConcerned")]
    public void ThiruConcerned() {
        Debug.Log("Sprite Called");
        spriteRenderer.sprite = ThiruConcernedS;
    }

    [YarnCommand("ThiruDisappointed")]
    public void ThiruDisappointed() {
        spriteRenderer.sprite = ThiruDisappointedS;
    }


    [YarnCommand("ThiruAmused")]
    public void ThiruAmused() {
        spriteRenderer.sprite = ThiruAmusedS;
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
        Debug.Log("PhoneTense");
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
