using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject HighScore;
    public GameObject ScoreText;
    public static float highScore;
    public static float scoreValue = 0f;
    TextMesh score;
    TextMesh high;
    // Start is called before the first frame update
    void Start()
    {
        DestroyScript.Life = 3;
        scoreValue = 0f;
        score = ScoreText.GetComponent<TextMesh>();
        high = HighScore.GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        if(scoreValue > highScore){
            highScore = scoreValue;
        }
        score.text = scoreValue.ToString();
        high.text = "High Score: " + highScore.ToString();
    }
}
