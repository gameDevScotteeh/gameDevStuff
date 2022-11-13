using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stairs : MonoBehaviour
{
    GameManger gm;
    public int nextLevel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag ==  "Player")
        {
            gm.LoadNextLevel(nextLevel);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManger>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
