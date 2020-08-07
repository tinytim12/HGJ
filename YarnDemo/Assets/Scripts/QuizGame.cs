using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class QuizGame : MonoBehaviour
{
    //main character thingies, score to be saved, time to be adjusted as per story
    public int score = 0;
    public float timeMain = 60; // change this to change overall time
    public bool timeActive = true;
    public float time = 60;
    public int questionNumber = 0;
    public bool exam = false;

    //plonk questions here
    public string[] questionsArray = new string[20] {
        "Which of these is not a Uniformed Group in Singapore?",
        "Which of these figures is represented with a statue at Raffles' Landing Site?",
        "In 2018, Leong Sze Hian was sued for defamation. He had previously said:",
        "What is Singapore’s aim to cut its carbon emissions?",
        "Which of these are not gazetted National Monuments in Singapore?",
        "This play was written by Stella Kon, detailing the life of a Peranakan matriarch in Singapore. What is it called?",
        "Which of these plants is not native to Singapore?",
        "One of the first five MRT stations was",
        "The water agreement that was signed in 1962 between Singapore and Malaysia expired in",
        "In __, Malaysia and Indonesia conducted Operation Pukul Habis near the Singaporean border during National Day.",
        "The Jackson Plan is:",
        "What is the name of the national flower of Singapore?",
        "The theme of the $100 bill is:",
        "Wilmar International, a company dealing in _, is headquartered in Singapore.",
        "Singapore won an Olympic medal in __ during the Rome Olympics in 1960.",
        "Which of these men was not a founder of the People’s Action Party?",
        "In 2013, AWARE protested the lyrics of this famous army marching song.",
        "To order a hot double shot Americano with no sugar, you’d tell the coffee shop:",
        "In 1980, the University of Singapore and Nanyang University merged to form:",
        "This film, produced by Ramasamy Madhavan depicting a migrant worker’s expenses in Singapore, is called:"
    };

    //question arrays are based on options, this is cuz arrays in C# aren't as easy to concat a var name as it is in javascript
    public string[] optionOneArray = new string[20] {
        "Boys’ Brigade",
        "Naraina Pillai",
        "The PAP was anti-Christian, Chinese and chauvinist",
        "Zero net emissions before 2050",
        "Haw Par Villa",
        "Notes from An Even Smaller Island",
        "Rattleweed",
        "Nee Soon",
        "2002",
        "1980",
        "DPM Heng Swee Kiat’s first draft for the East Coast Plan",
        "Verandah Miss Joaquin",
        "Youth",
        "Diesel",
        "Weightlifting",
        "Lim Kim San",
        "I Saw My Girl",
        "Teh O Siu Dai",
        "NUS",
        "Stranger to Myself"
    };

    public string[] optionTwoArray = new string[20] {
        "St Andrew’s First Aid",
        "Tan Kah Kee",
        "PM Lee had misused CPF",
        "Reduce emissions to 100 million tonnes by 2020",
        "Chung Cheng High School (Main)",
        "The Coffin Is Too Big For The Hole",
        "Rain tree",
        "Orchard Road",
        "2007",
        "1991",
        "A stimulus package intended to bail Singapore out of the Asian Financial Crisis",
        "Vanda Miss Joaquim",
        "Education",
        "Palm oil",
        "Swimming",
        "Lim Chin Siong",
        "Training to be Soldiers",
        "Kopi C Peng",
        "NTU",
        "$alary Day"
    };

    public string[] optionThreeArray = new string[20] {
        "Red Cross",
        "William Pickering",
        "PM Lee had helped Malaysian PM Najib Razak launder money",
        "Reduce emissions by 50 million tonnes before 2045",
        "Prinsep Street Presbyterian Church",
        "Emily of Emerald Hill",
        "Lipstick Plant",
        "Jurong East",
        "2011",
        "1996",
        "The roadmap for British troops to leave Singapore before 1971",
        "Vantah Miss Joaquim",
        "Garden City",
        "Rubber",
        "Table tennis",
        "Lim Yew Hock",
        "Bookout Day",
        "Kopi O Kosong Gao",
        "SMU",
        "Long Long Time Ago"
    };

    public string[] optionFourArray = new string[20] {
        "National Civil Defence Cadet Corps",
        "Yusof Ishak",
        "A PAP minister was a liar",
        "Limit emissions to 65 million tonnes by 2030",
        "Sri Temasek",
        "Everything but the Brain",
        "Orange Crepe Ginger",
        "Braddell",
        "2012",
        "1998",
        "The first city plan drawn for colonial Singapore",
        "Venta Miss Joaquin",
        "Sports",
        "Fisheries",
        "Gymnastics",
        "Lee Kuan Yew",
        "Purple Light",
        "Teh O Kosong Peng",
        "SUSS",
        "Crazy Rich Asians"
    };

    public string[] allAnswersArray = new string[20] {
        "St Andrew’s First Aid",
        "Naraina Pillai",
        "PM Lee had helped Malaysian PM Najib Razak launder money",
        "Limit emissions to 65 million tonnes by 2030",
        "Haw Par Villa",
        "Emily of Emerald Hill",
        "Rain tree",
        "Braddell",
        "2011",
        "1991",
        "The first city plan drawn for colonial Singapore",
        "Vanda Miss Joaquim",
        "Youth",
        "Palm oil",
        "Weightlifting",
        "Lim Yew Hock",
        "Purple Light",
        "Kopi O Kosong Gao",
        "NUS",
        "$alary Day"
    };

    public int round = 0;
    public int[] answeredQ = new int[20]
    {
        21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21
    };

    public GameObject rightScreen;
    public GameObject wrongScreen;
    public GameObject finalScreen;

    public GameObject timeTextGO;


    public GameController gameController;


    void Awake()  //this whole awake function is googled in a attempt to not lose the variables. adjustable if you know what's going on, cuz i sure as hell dont
    {

    }

    // Start is called before the first frame update
    void Start() {
        timeTextGO = GameObject.Find("timeText");

        rightScreen = GameObject.Find("questionRight");
        rightScreen.SetActive(false);
        wrongScreen = GameObject.Find("questionWrong");
        wrongScreen.SetActive(false);
        finalScreen = GameObject.Find("finalScore");
        finalScreen.SetActive(false);
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
        exam = gameController.getTest();

        if (exam) {
            time = 30;
        } else {
            time = gameController.getTime();
        }

        if (exam) {
            Image img = GameObject.Find("mainBG").GetComponent<Image>();
            img.color = UnityEngine.Color.black;
            //change background color

        }

        shuffleQNA();
    }

    // Update is called once per frame
    void Update() {
        var timeText = timeTextGO.GetComponent<TextMeshProUGUI>();

        if (timeActive && (!rightScreen.activeSelf || !wrongScreen.activeSelf)) {
            time -= Time.deltaTime;
            timeText.text = "Time Left:" + Mathf.Round(time);
            if (time < 0) {
                endGame();
            }
        }

        if (round == 20 && (!rightScreen.activeSelf || !wrongScreen.activeSelf)) {
            endGame();
        }
    }

    void endGame() {
        finalScreen.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Final score: " + score + "/20";
        finalScreen.SetActive(true);
    }


    public void OnButtonClick() {
        //get button that is selected
        var es = EventSystem.current;
        var go = es.currentSelectedGameObject; //go is the button gameobject itself
        var tmpText = go.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();



        if (round < 19) {
            checkQuestion(tmpText.text);
            round = round + 1;
            shuffleQNA();
        } else {
            checkQuestion(tmpText.text);
            round = round + 1;
        }
        //display correct screen & change scene back to dialogue

    }


    void checkQuestion(string btnTxt) {
        var correct = false;
        var correctAns = allAnswersArray[questionNumber];

        for (int i = 0; i < questionsArray.Length; i++) {

            if (btnTxt == allAnswersArray[i]) {
                correct = true;
                break;
            } else {
                correct = false;
            }
        }

        if (correct) {
            questionRight(correctAns);
        } else {
            questionWrong(correctAns);
        }
    }

    void questionRight(string answer) {
        rightScreen.SetActive(true);
        score = score + 1;

    }

    void questionWrong(string answer) {
        wrongScreen.SetActive(true);
        wrongScreen.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = "Wrong! The correct answer is: " + answer;
    }


    void shuffleQNA() {
        var questions = "";
        var answerSet = new string[4];
        //shuffle array based on round
        questionNumber = 0;
        var conflict = true;
        questionNumber = Random.Range(0, 20); //sets the question
        questions = questionsArray[questionNumber]; //takes the string


        for (int i = 0; i < answeredQ.Length; i++) {
            if (questionNumber != answeredQ[i]) {
                //take the options
                answerSet[0] = optionOneArray[questionNumber];
                answerSet[1] = optionTwoArray[questionNumber];
                answerSet[2] = optionThreeArray[questionNumber];
                answerSet[3] = optionFourArray[questionNumber];
                conflict = false;
            } else {
                conflict = true;
                break;
            }

        }

        if (conflict && round < 19) {
            shuffleQNA();
        } else if (!conflict) {
            answeredQ[round] = questionNumber;
            displayQNA(questions, answerSet);

        } else {

        }
    }

    void displayQNA(string questionName, string[] answerSet) {
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

    public void goToSleep() {
        gameController.increment();
        if (score > 10) {

        } else {

        }
        SceneManager.LoadScene("Classroom");
    }

}
