using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;


public class GameController : MonoBehaviour {
    public int day;
    // Start is called before the first frame update
    public SpriteRenderer bg;

    public Sprite staffroomBackground;
    public Sprite canteenBackground;
    public Sprite corridorBackground;

    public SpriteManager SpriteManager;

    public bool fadeDoing;

    public DialogueRunner dialogue;

    void Awake() {
        day = 1;
        DontDestroyOnLoad(this.gameObject);
    }

    void Start() {
    }

    // Update is called once per frame
    void Update() {

    }

    public void switchToHallway() {
        SceneManager.LoadScene("Hallway");
    }

    [YarnCommand("getDay")]
    public int getDay() {
        return day;
    }

    [YarnCommand("changeScene")]
    public void changeScene(string background) {
        SpriteManager.NoSprite();
        if (background == "staffroom") {
            bg.sprite = staffroomBackground;
        }
        if (background == "canteen") {
            bg.sprite = canteenBackground;
        }
        if (background == "corridor") {
            bg.sprite = corridorBackground;
        }
    }

    [YarnCommand("homework")]
    public void homework() {

    }

    [YarnCommand("startFadeIn")]
    public void startFadeIn(string time) {
        float newTime = float.Parse(time);
        StartCoroutine(FadeIn(newTime));
    }

    [YarnCommand("startFadeOut")]
    public void startFadeOut(string time) {
        float newTime = float.Parse(time);
        StartCoroutine(FadeOut(newTime));
    }

    public IEnumerator FadeIn(float aTime) {
        float alpha = SpriteManager.GetComponent<SpriteRenderer>().material.color.a;
        for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / aTime) {
            Color newColor = new Color(1, 1, 1, Mathf.Lerp(alpha, 1, t));
            SpriteManager.GetComponent<SpriteRenderer>().material.color = newColor;
            yield return null;
        }
    }

    public IEnumerator FadeOut(float aTime) {
        float alpha = SpriteManager.GetComponent<SpriteRenderer>().material.color.a;
        for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / aTime) {
            Color newColor = new Color(1, 1, 1, Mathf.Lerp(alpha, 0, t));
            SpriteManager.GetComponent<SpriteRenderer>().material.color = newColor;
            yield return null;
        }
    }

}
