using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*public class pauseUI : MonoBehaviour
{

    [SerializeField]
    private Button restartGameButton;

    [SerializeField]
    private GameObject pausePanel;

    void Awake()
    {
        MakeInstance();
        Time.timeScale = 0f;
    }

    void MakeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void pauseGame()
    {
        if (BirdScripts.instance != null)
        {
            if (BirdScripts.instance.isAlive)
            {
                pausePanel.SetActive(true);
                Time.timeScale = 0f;
                restartGameButton.onClick.RemoveAllListeners();
                restartGameButton.onClick.AddListener(() => resumeGame());
            }
        }
    }

    public void goToMenu()
    {
        SceneManager.LoadScene("Scene_Menu");
    }

    public void resumeGame()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void restartGame()
    {
        SceneManager.LoadScene("Scene_Play");
    }

    public void playGame()
    {
        ScoreText.gameObject.SetActive(true);
        birds.SetActive(true);
        instructionButton.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Quit()
    {
        CommonDevTools.QUIT_APP("! fin demandée de l'application!");
    }
}*/