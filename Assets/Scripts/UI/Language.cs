using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Language
{
    [SerializeField]
    string FRtext;

    [SerializeField]
    string ENtext;

    [HideInInspector] public Text texte;

    void Start()
    {
        ChangeLanguage();
    }

    void OnEnable()
    {
        ChangeLanguage();
    }

    public void ChangeLanguage()
    {
        if (PlayerPrefs.HasKey("language") && PlayerPrefs.GetString("language") == "FR")
        {
            texte.text = FRtext;
        }
        else
        {
            texte.text = ENtext;
        }
    }
}
