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
}
