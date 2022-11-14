using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupManager : MonoBehaviour
{
    public PlayerController playerCharacter;
    public float buffTime;
    public float timePassed;
    public bool isBuffed;
    // Start is called before the first frame update
    void Start()
    {
        playerCharacter = FindObjectOfType<PlayerController>();
        isBuffed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isBuffed)
        {
            timePassed += Time.deltaTime;
            if (timePassed >= buffTime)
            {
                playerCharacter.timeBetweenShots = 0.1f;
                timePassed = 0;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            Destroy(this);
            isBuffed = true;
            playerCharacter.timeBetweenShots = 0.0001f;
        }
    }
}
