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
    public Sprite JamesTiredS;
    public Sprite JamesEvenMoreTiredS;
    public Sprite JamesDisappointedS;
    public Sprite JamesWorriedS;
    public Sprite JamesHopefulS;
    public Sprite JamesFrustratedS;
    public Sprite JamesFrustrationS;
    public Sprite SitiHappyS;
    public Sprite SitiAnnoyedS;
    public Sprite SitiWorried2S;
    public Sprite SitiWorriedS;
    public Sprite SitiHopefulS;
    public Sprite PhoneTenseS;
    public Sprite PhoneDullS;
    public Sprite PhoneRelaxedS;
    public Sprite PhoneHopefulS;

    public SpriteRenderer spriteRenderer;

    public Sprite Classroom;

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
        spriteRenderer.sprite = JamesTiredS;
    }

    [YarnCommand("JamesEvenMoreTired")]
    public void JamesEvenMoreTired() {
        spriteRenderer.sprite = JamesEvenMoreTiredS;
    }

    [YarnCommand("JamesWorried")]
    public void JamesWorried() {
        spriteRenderer.sprite = JamesWorriedS;
    }

    [YarnCommand("JamesDisappointed")]
    public void JamesDisappointed() {
        spriteRenderer.sprite = JamesDisappointedS;
    }

    [YarnCommand("JamesHopeful")]
    public void JamesHopeful() {
        spriteRenderer.sprite = JamesHopefulS;
    }

    [YarnCommand("JamesFrustrated")]
    public void JamesFrustrated() {
        spriteRenderer.sprite = JamesFrustratedS;
    }

    [YarnCommand("JamesFrustration")]
    public void JamesFrustration() {
        spriteRenderer.sprite = JamesFrustrationS;
    }

    [YarnCommand("SitiHappy")]
    public void SitiHappy() {
        spriteRenderer.sprite = SitiHappyS;
    }

    [YarnCommand("SitiAnnoyed")]
    public void SitiAnnoyed() {
        spriteRenderer.sprite = SitiAnnoyedS;
    }

    [YarnCommand("SitiWorried2")]
    public void SitiWorried2() {
        spriteRenderer.sprite = SitiWorried2S;
    }

    [YarnCommand("SitiWorried")]
    public void SitiWorried() {
        spriteRenderer.sprite = SitiWorriedS;
    }

    [YarnCommand("SitiHopeful")]
    public void SitiHopeful() {
        spriteRenderer.sprite = SitiHopefulS;
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
