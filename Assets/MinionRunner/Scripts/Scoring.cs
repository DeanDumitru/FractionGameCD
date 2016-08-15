using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Scoring : MonoBehaviour {

    private static Scoring instance;



    public Text scoreText;
    public static int score;

    void Start () {
        score = 0;
	}

    void Update()
    {
        scoreText.text = "Score: " + score;
    }
}
