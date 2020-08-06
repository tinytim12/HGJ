using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class QuizGame : MonoBehaviour
{
    public GameController gameController; //honestly this is to keep it on top? idk i googled this

    //main character thingies, score to be saved, time to be adjusted as per story
    public int score = 0;
    public float time;
    public bool timeActive = true;
    public int fullScore;

    //plonk questions here
    public string[] questionsArray = new string[3] { "insert question one here", "insert question two here", "insert question three here" };

    //question arrays are based on options, this is cuz arrays in C# aren't as easy to concat a var name as it is in javascript
    public string[] optionOneArray = new string[3] { "question one option one (correct)", "question two option one", "question three option one" };
    public string[] optionTwoArray = new string[3] { "question one option two", "question two option two", "question three option two(correct)" };
    public string[] optionThreeArray = new string[3] { "question one option three", "question two option three(correct)", "question three option three" };
    public string[] optionFourArray = new string[3] { "question one option four", "question two option four", "question three option four" };

    public int round = 0;
    public int[] answeredQ = new int[3];

    public GameObject rightScreen;
    public GameObject wrongScreen;
    public GameObject endQuiz;

    public GameObject timeTextGO;
 

    


    void Awake()  //this whole awake function is googled in a attempt to not lose the variables. adjustable if you know what's going on, cuz i sure as hell dont
    {
  
    }

    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        time = gameController.getTime();
        timeTextGO = GameObject.Find("timeText");
        rightScreen.SetActive(false);
        wrongScreen.SetActive(false);
        endQuiz.SetActive(false);
        
        shuffleQNA();
    }

    // Update is called once per frame
    void Update()
    {
        var timeText = timeTextGO.GetComponent<TextMeshProUGUI>();

        if (timeActive && (!rightScreen.activeSelf || !wrongScreen.activeSelf))
        {
            time -= Time.deltaTime;
            timeText.text = "Time Left:" + Mathf.Round(time);
            if (time < 0)
            {
                questionWrong();
            }
        }
    }


    public void OnButtonClick()
    {
        //get button that is selected
        var es = EventSystem.current;
        var go = es.currentSelectedGameObject; //go is the button gameobject itself
        var tmpText = go.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();

        //Debug.Log(tmpText.text);

        //if statements for each round
        //hard code answers? match string with txt.GetComponent<TextMeshProUGUI>().text
        //update score if right

        checkQuestion(tmpText.text);

        round = round + 1;
        shuffleQNA();
        //display correct screen & change scene back to dialogue

    }


    void checkQuestion(string btnTxt)
    {
        if (btnTxt == "question one option one (correct)" || btnTxt == "question three option two(correct)" || btnTxt == "question two option three(correct)")
        {           
            questionRight();
        }
        else
        {
            questionWrong();
        }
    }

    void questionRight()
    {
        score = score + 100;
        rightScreen.SetActive(true);
    }

    void questionWrong()
    {
        endGame();
    }


    void shuffleQNA()
    {
        var questions = "";
        var answerSet = new string[4];
        var questionNumber = 0;
        //shuffle array based on round
        if (round == 0)
        {
            questionNumber = Random.Range(0, 3); //sets the question
            questions = questionsArray[questionNumber]; //takes the string

            //take the options
            answerSet[0] = optionOneArray[questionNumber];
            answerSet[1] = optionTwoArray[questionNumber];
            answerSet[2] = optionThreeArray[questionNumber];
            answerSet[3] = optionFourArray[questionNumber];

            //set answeredQ[0] to the question number
            answeredQ[round] = questionNumber;

            displayQNA(questions, answerSet);

        }
        else if (round == 1)
        {

            questionNumber = Random.Range(0, 3); //sets the question
            questions = questionsArray[questionNumber]; //takes the string

            if (questionNumber != answeredQ[round-1])
            {

                //take the options
                answerSet[0] = optionOneArray[questionNumber];
                answerSet[1] = optionTwoArray[questionNumber];
                answerSet[2] = optionThreeArray[questionNumber];
                answerSet[3] = optionFourArray[questionNumber];

                displayQNA(questions, answerSet);
                answeredQ[round] = questionNumber;
            }
            else
            {
                shuffleQNA();
            }
            
        }
        else if (round == 2)
        {
            questionNumber = Random.Range(0, 3); //sets the question
            questions = questionsArray[questionNumber]; //takes the string

            if (questionNumber != answeredQ[round - 1])
            {
                //take the options
                answerSet[0] = optionOneArray[questionNumber];
                answerSet[1] = optionTwoArray[questionNumber];
                answerSet[2] = optionThreeArray[questionNumber];
                answerSet[3] = optionFourArray[questionNumber];

                displayQNA(questions, answerSet);
                answeredQ[round] = questionNumber;
            }
            else
            {
                shuffleQNA();
            }
            
        }


        //insert array text into relevant fields

        //start countdown
    }

    void displayQNA(string questionName, string[] answerSet)
    {
        var questionGO = GameObject.Find("questionBox");
        var tmpQN = questionGO.GetComponent<TextMeshProUGUI>();

        tmpQN.text = questionName;

        //select gameobjects questions and answers and set text
        var btnOneGO = GameObject.Find("optionOne");
        var tmpTextOne = btnOneGO.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();

        var btnTwoGO = GameObject.Find("optionTwo");
        var tmpTextTwo = btnTwoGO.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();

        var btnThreeGO = GameObject.Find("optionThree");
        var tmpTextThree = btnThreeGO.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();

        var btnFourGO = GameObject.Find("optionFour");
        var tmpTextFour = btnFourGO.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();

        tmpTextOne.text = answerSet[0];
        tmpTextTwo.text = answerSet[1];
        tmpTextThree.text = answerSet[2];
        tmpTextFour.text = answerSet[3];

    }

    void endGame() {
        endQuiz.SetActive(true);
        string message = "Your score is " + score + ". You have " + ((fullScore - score) / questionsArray.Length) + "questions wrong.";
        endQuiz.transform.GetChild(0).gameObject.GetComponent<Text>().text = message;
    }

    public void goToSleep() {
        gameController.increment();
        SceneManager.LoadScene("Classroom");
    }
 
}
