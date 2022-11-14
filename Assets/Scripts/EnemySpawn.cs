using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int spawnAmount = 1;
    public float timePassed = 0f;
    public Vector2 spawnRange;
    public float interval = 3f;
    public float radius = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // spawns enemies every x interval
        timePassed += Time.deltaTime;
        if (timePassed > interval)
        {
            for (int i = 0; i < spawnAmount; i++)
            {
                Vector2 randomPos;
                randomPos.x = Random.Range(-spawnRange.x, spawnRange.x);
                randomPos.y = Random.Range(-spawnRange.y, spawnRange.y);

                while (Physics2D.OverlapCircle(randomPos, radius))
                {
                    randomPos.x = Random.Range(-spawnRange.x, spawnRange.x);
                    randomPos.y = Random.Range(-spawnRange.y, spawnRange.y);
                }
                GameObject spawnedObject = (GameObject)Instantiate(enemyPrefab);
                spawnedObject.transform.Translate(randomPos, 0);
            }
            timePassed = 0;
        }
    }
}
