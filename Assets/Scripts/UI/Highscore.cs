using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(!PlayerPrefs.HasKey("language") || PlayerPrefs.GetString("language") == "EN") this.GetComponent<Text>().text = "Highscore : " + PlayerPrefs.GetInt("Highscore").ToString() + " ";
        else if (PlayerPrefs.GetString("language") == "FR") this.GetComponent<Text>().text = "Meilleur score : " + PlayerPrefs.GetInt("Highscore").ToString() + " ";
    }
}
