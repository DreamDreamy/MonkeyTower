using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Evenements : MonoBehaviour {
    

    public void PressPlay() {
        _MGR_SceneManager.Instance.LoadScene("Scene_Play");
    }

    public void PressCredit()
    {
        _MGR_SceneManager.Instance.LoadScene("Scene_Credit");
    }

    public void PressMulti()
    {
        _MGR_SceneManager.Instance.LoadScene("Scene_MultiplayerHub");
    }

    public void PressMenu()
    {
        if (!PlayerPrefs.HasKey("language")) _MGR_SceneManager.Instance.LoadScene("Scene_Language");
        else _MGR_SceneManager.Instance.LoadScene("Scene_Menu");
    }

    public void PressLanguage()
    {
        _MGR_SceneManager.Instance.LoadScene("Scene_Language");
    }

    public void PressSkills()
    {
        _MGR_SceneManager.Instance.LoadScene("Scene_Skills");
    }

    public void PressQuit() {
        Application.Quit();
    }

    public void PressFrancais()
    {
        PlayerPrefs.SetString("language", "FR");
        _MGR_SceneManager.Instance.LoadScene("Scene_Menu");
    }

    public void PressEnglish()
    {
        PlayerPrefs.SetString("language", "EN");
        _MGR_SceneManager.Instance.LoadScene("Scene_Menu");
    }

}
