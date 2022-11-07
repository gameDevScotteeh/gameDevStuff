using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMenu : MonoBehaviour
{
    public string firstLevel;
    public string controls;
    
    public void NewGame()
    {
        SceneManager.LoadSceneAsync(firstLevel);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ControlsButton()
    {
        SceneManager.LoadSceneAsync(controls);
    }
}
