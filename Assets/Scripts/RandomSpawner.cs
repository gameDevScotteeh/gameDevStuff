using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] EnemyPrefab;
    public int spawnAmount = 1;
    public float timePassed = 0f;
    public float interval = 3f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        if (timePassed > interval)
        {
            for (int i = 0; i < spawnAmount; i++)
            {
                foreach (Transform sp in spawnPoints)
                {
                    int randEnemy = Random.Range(0, EnemyPrefab.Length);
                    Instantiate(EnemyPrefab[randEnemy], sp.position, transform.rotation);
                }
            }
            timePassed = 0;
        }
    }
}
