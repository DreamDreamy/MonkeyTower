using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class __LaunchGame : MonoBehaviour
{
    void Start()
    {
        _MGR_SceneManager.Instance.LoadScene("Scene_BeforeMenu");
        if (!PlayerPrefs.HasKey("Highscore")) PlayerPrefs.SetInt("Highscore", 0);
        if (!PlayerPrefs.HasKey("Coins")) PlayerPrefs.SetInt("Coins", 0);
    }
}


