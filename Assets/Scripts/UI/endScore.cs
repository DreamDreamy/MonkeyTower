using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endScore : MonoBehaviour
{
    void Start()
    {
        this.GetComponent<Text>().text = "Score : " + PlayerPrefs.GetInt("Score").ToString() + " ";
    }
}
