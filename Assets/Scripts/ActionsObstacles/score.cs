using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : Singleton<score>
{
    Text scoreText;
    float scoreNow;

    void Start()
    {
        scoreText = this.GetComponent<Text>();
        scoreNow = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreNow += PlayerStats.Instance.scoreSpeed * Time.deltaTime;
        int scoreToAdd = (int)scoreNow;
        scoreText.text = scoreToAdd.ToString();
        PlayerPrefs.SetInt("Score", scoreToAdd);
        if (PlayerPrefs.GetInt("Highscore") < scoreToAdd) PlayerPrefs.SetInt("Highscore", scoreToAdd);
    }
}
