using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllsMenu : MonoBehaviour
{
    public string titleScene;
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
}
