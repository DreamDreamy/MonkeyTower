using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : Singleton<Coins>
{
    public Text coinsText;

    void Start()
    {
        coinsText.text = PlayerPrefs.GetInt("Coins").ToString() + " ";
    }

    public void addCoin()
    {
        PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + 1);
        coinsText.text = PlayerPrefs.GetInt("Coins").ToString() + " ";
    }

    public void suppCoin(int nbCoinsToSupp)
    {
        PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - nbCoinsToSupp);
        coinsText.text = PlayerPrefs.GetInt("Coins").ToString() + " ";
    }
}
