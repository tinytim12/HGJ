using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;


public class GameController : MonoBehaviour {
    public int day;
    // Start is called before the first frame update

    public int time;
    public SpriteRenderer bg;

    public Sprite staffroomBackground;
    public Sprite canteenBackground;
    public Sprite corridorBackground;
    public Sprite homeBackground;

    public SpriteManager SpriteManager;

    public bool fadeDoing;

    public DialogueRunner dialogue;

    void Awake() {
        day = 1;
        DontDestroyOnLoad(this.gameObject);
        bg.material.color = new Color(1, 1, 1, 0);
        SpriteManager.GetComponent<SpriteRenderer>().material.color = new Color(1, 1, 1, 0);
    }

    void Start() {
    }

    // Update is called once per frame
    void Update() {

    }

    public void switchToHallway() {
        SceneManager.LoadScene("Hallway");
    }

    [YarnCommand("getTime")]
    public int getTime() {
        return time;
    }

    [YarnCommand("setTime")]
    public void setTime(int t) {
        time = t; 
    }

    [YarnCommand("getDay")]
    public int getDay() {
        return day;
    }

    public void increment() {
        day = day + 1;
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
        if (background == "home") {
            Debug.Log("home");
            bg.sprite = homeBackground;
        }
    }

    [YarnCommand("homework")]
    public void homework() {
        SceneManager.LoadScene("Quiz");
    }

    [YarnCommand("startFadeIn")]
    public void startFadeIn(string time, string obj) {
        float newTime = float.Parse(time);
        Debug.Log(obj);
        if (obj == "s") {
            StartCoroutine(FadeInS(newTime));
        } else if (obj == "bg") {
           
            StartCoroutine(FadeInBg(newTime));
        }
    }

    [YarnCommand("startFadeOut")]
    public void startFadeOut(string time, string obj) {
        float newTime = float.Parse(time);
        if (obj == "s") {
            StartCoroutine(FadeOutS(newTime));
        } else if (obj == "bg") {
            StartCoroutine(FadeOutBg(newTime));
        }
    }

    public IEnumerator FadeInS(float aTime) {

        for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / aTime) {
            // set color with i as alpha
            SpriteManager.GetComponent<SpriteRenderer>().material.color = new Color(1, 1, 1, t);
            yield return null;
        }
    }

    public IEnumerator FadeOutS(float aTime) {
        for (float t = 1.0f; t > 0.0f; t -= Time.deltaTime / aTime) {
            // set color with i as alpha
            SpriteManager.GetComponent<SpriteRenderer>().material.color = new Color(1, 1, 1, t);
            yield return null;
        }
    }

    public IEnumerator FadeInBg(float aTime) {
        for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / aTime) {
            // set color with i as alpha
            Debug.Log(t);
            bg.material.color = new Color(1, 1, 1, t);
            yield return null;
        }
    }

    public IEnumerator FadeOutBg(float aTime) {
        for (float t = 1.0f; t > 0.0f ; t -= Time.deltaTime / aTime) {
            // set color with i as alpha
            Debug.Log(t);
            bg.material.color = new Color(1, 1, 1, t);
            yield return null;
        }
    }

}
