using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;


public class GameController : MonoBehaviour {
    public int day;
    // Start is called before the first frame update

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
    public void changeScene() {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Classroom") {
            SceneManager.LoadScene("Corridor");
        }
        if (scene.name == "Corridor") {
            SceneManager.LoadScene("Home");
        }
    }
}
