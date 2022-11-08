using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShootingController : MonoBehaviour
{
    public float speed;
    public float timeToLive;
    Vector3 moveVector;


    void Start()
    {
        moveVector = Vector3.up * speed * Time.fixedDeltaTime;
        StartCoroutine(DestroyBlast());
    }


    private void FixedUpdate()
    {
        transform.Translate(moveVector);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }
    }
    IEnumerator DestroyBlast()
    {
        yield return new WaitForSeconds(timeToLive);
        Destroy(gameObject);
    }
}
