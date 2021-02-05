using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamePlayController : MonoBehaviour {

	public static GamePlayController instance;

    [SerializeField]
    private Button restartGameButton;

    [SerializeField]
    private GameObject pausePanel;

	void Awake() {
		MakeInstance ();
		Time.timeScale = 1f;
	}

    void Update()
    {
        if (Input.GetButtonDown("Pause")) pauseGame();
    }
    
	void MakeInstance () {
		if (instance == null) {
			instance = this;
		}
	}

	public void pauseGame()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0f;
        pausePanel.SetActive (true);
        restartGameButton.onClick.RemoveAllListeners();
        restartGameButton.onClick.AddListener(() => resumeGame());
	}

	public void goToMenu() {
		SceneManager.LoadScene ("Scene_Menu");
	}

	public void resumeGame()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        pausePanel.SetActive (false);
		Time.timeScale = 1f;
	}

	public void restartGame() {
		SceneManager.LoadScene ("Scene_Play");
	}

    public void Quit()
    {
        CommonDevTools.QUIT_APP("quit");
    }
}






























