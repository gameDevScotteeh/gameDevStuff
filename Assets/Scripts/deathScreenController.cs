using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathScreenController : MonoBehaviour
{
    public string titleScene;
    public string restartScene;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void QuitToMenu()
    {
        SceneManager.LoadSceneAsync(titleScene);
    }
    public void Restart()
    {
        SceneManager.LoadSceneAsync(restartScene);
    }
}
