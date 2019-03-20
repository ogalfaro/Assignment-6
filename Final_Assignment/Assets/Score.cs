using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject ScoreText;
    public static float scoreValue = 0f;
    TextMesh score;
    // Start is called before the first frame update
    void Start()
    {
        score = ScoreText.GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = scoreValue.ToString();
    }
}
