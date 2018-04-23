using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour {

    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    private InputManager inputManager;
    private PauseMenuShards pauseMenuShards;

    void Start()
    {
        if (!(inputManager = this.GetComponent<InputManager>()))
            inputManager = this.gameObject.AddComponent<InputManager>();
    }
	
	void Update () {

        if (inputManager.Pause())
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
	}

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        pauseMenuShards.randomShard();
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        Debug.Log("Loading");
        SceneManager.LoadScene("SceneMenu");
    }

    public void QuitGame()
    {
        Debug.Log("Quiting Game...");
        Application.Quit();
    }
}
