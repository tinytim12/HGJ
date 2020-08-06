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
    public Sprite Phone;

    public SpriteRenderer spriteRenderer;
    public SpriteRenderer bg;

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
        spriteRenderer.sprite = Phone;
        StartCoroutine(PhoneTenseC());
    }

    public IEnumerator PhoneTenseC() {
        Color currentColor = bg.GetComponent<SpriteRenderer>().material.color;
        float currentRed = currentColor.r;
        float currentGreen = currentColor.g;
        float currentBlue = currentColor.b;
        float currentAlpha = currentColor.a;
        for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / 1) {
            // set color with i as alpha
            float r = Mathf.Lerp(currentRed, 0.5f, t);
            float g = Mathf.Lerp(currentGreen, 0.1f, t);
            float b = Mathf.Lerp(currentBlue, 0.1f, t);
            float a = Mathf.Lerp(currentAlpha, 0.6f, t);
            bg.GetComponent<SpriteRenderer>().material.color = new Color(r, g, b, a);
            yield return null;
        }
    }

    [YarnCommand("PhoneDull")]
    public void PhoneDull() {
        spriteRenderer.sprite = Phone;
        StartCoroutine(PhoneDullC());
    }

    public IEnumerator PhoneDullC() {
        Color currentColor = bg.GetComponent<SpriteRenderer>().material.color;
        float currentRed = currentColor.r;
        float currentGreen = currentColor.g;
        float currentBlue = currentColor.b;
        float currentAlpha = currentColor.a;
        for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / 1) {
            // set color with i as alpha
            float r = Mathf.Lerp(currentRed, 0f, t);
            float g = Mathf.Lerp(currentGreen, 0f, t);
            float b = Mathf.Lerp(currentBlue, 0f, t);
            float a = Mathf.Lerp(currentAlpha, 0.6f, t);
            bg.GetComponent<SpriteRenderer>().material.color = new Color(r, g, b, a);
            yield return null;
        }
    }

    [YarnCommand("PhoneRelaxed")]
    public void PhoneRelaxed() {
        spriteRenderer.sprite = Phone;
        StartCoroutine(PhoneRelaxedC());
    }

    public IEnumerator PhoneRelaxedC() {
        Color currentColor = bg.GetComponent<SpriteRenderer>().material.color;
        float currentRed = currentColor.r;
        float currentGreen = currentColor.g;
        float currentBlue = currentColor.b;
        float currentAlpha = currentColor.a;
        for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / 1) {
            // set color with i as alpha
            float r = Mathf.Lerp(currentRed, 0.1f, t);
            float g = Mathf.Lerp(currentGreen, 0.1f, t);
            float b = Mathf.Lerp(currentBlue, 0.6f, t);
            float a = Mathf.Lerp(currentAlpha, 0.6f, t);
            bg.GetComponent<SpriteRenderer>().material.color = new Color(r, g, b, a);
            yield return null;
        }
    }

    [YarnCommand("PhoneHopeful")]
    public void PhoneHopeful() {
        spriteRenderer.sprite = Phone;
        StartCoroutine(PhoneHopefulC());
    }

    public IEnumerator PhoneHopefulC() {
        Color currentColor = bg.GetComponent<SpriteRenderer>().material.color;
        float currentRed = currentColor.r;
        float currentGreen = currentColor.g;
        float currentBlue = currentColor.b;
        float currentAlpha = currentColor.a;
        for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / 1) {
            // set color with i as alpha
            float r = Mathf.Lerp(currentRed, 0.1f, t);
            float g = Mathf.Lerp(currentGreen, 0.6f, t);
            float b = Mathf.Lerp(currentBlue, 0.1f, t);
            float a = Mathf.Lerp(currentAlpha, 0.6f, t);
            bg.GetComponent<SpriteRenderer>().material.color = new Color(r, g, b, a);
            yield return null;
        }
    }
}
