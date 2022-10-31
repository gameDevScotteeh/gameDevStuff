using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 leftStickInput;
    private Vector2 rightStickInput;
    private Vector2 mousePos;
    public Camera cam;

    public GameObject plasmaBlastPrefab;
    public Transform firePointLeft;
    public Transform firePointRight;
    public float timeBetweenShots;
    public bool canShoot;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        canShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        GetPlayerInput();

    }

    private void GetPlayerInput()
    {
        leftStickInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        rightStickInput = new Vector2(Input.GetAxis("R_Horizontal"), Input.GetAxis("R_Vertical"));


        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }
    private void FixedUpdate()
    {
        Vector2 currMovement = leftStickInput * playerSpeed * Time.deltaTime;

        rb.MovePosition(rb.position + currMovement);
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg -90f;
        rb.rotation = angle;

        if (canShoot)
        {
            Shoot();
        }

    }

    private void Shoot()
    {
        canShoot = false;
        Instantiate(plasmaBlastPrefab, firePointLeft.position, transform.rotation);
        Instantiate(plasmaBlastPrefab, firePointRight.position, transform.rotation);
        StartCoroutine(ShotCooldown());
    }
    IEnumerator ShotCooldown()
    {
        yield return new WaitForSeconds(timeBetweenShots);
        canShoot = true;
    }
}
