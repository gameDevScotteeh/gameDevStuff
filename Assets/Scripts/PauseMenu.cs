using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public string titleScene;
    public bool isPaused = false;
    public GameObject pauseCanvas;

    void Start()
    {
        pauseCanvas.SetActive(isPaused);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
            pauseCanvas.SetActive(!isPaused);
            Time.timeScale = Convert.ToInt32(isPaused);
        }
    }
    public void QuitToMenu()
    {
        SceneManager.LoadSceneAsync(titleScene);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
