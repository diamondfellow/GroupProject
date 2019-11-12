using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject prefab;
    public float shootSpeed = 5.0f;
    public float bulletLifetime = 1/5f;
    public float shootDelay = 1.0f;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetButton("Fire1") && timer > shootDelay && PlayerPickup.hasCrowbar == true)
        {
            timer = 0;
            GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
            Vector3 mousePosition = Input.mousePosition;
            Debug.Log("mouse position 1: " + mousePosition);
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            Debug.Log("mouse position 2: " + mousePosition);
            Vector2 shootDirection = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
            shootDirection.Normalize();
            bullet.GetComponent<Rigidbody2D>().velocity = shootDirection * shootSpeed;
            Destroy(bullet, bulletLifetime);
        }
        else if (Input.GetButton("Fire1") && timer > shootDelay && PlayerPickup.hasRobotArm == true)
        {
            timer = 0;
            GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
            Vector3 mousePosition = Input.mousePosition;
            Debug.Log("mouse position 1: " + mousePosition);
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            Debug.Log("mouse position 2: " + mousePosition);
            Vector2 shootDirection = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
            shootDirection.Normalize();
            bullet.GetComponent<Rigidbody2D>().velocity = shootDirection * shootSpeed;
            Destroy(bullet, bulletLifetime);
        }
        else if (Input.GetButton("Fire1") && timer > shootDelay && PlayerPickup.hasMetalPipe == true)
        {
            timer = 0;
            GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
            Vector3 mousePosition = Input.mousePosition;
            Debug.Log("mouse position 1: " + mousePosition);
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            Debug.Log("mouse position 2: " + mousePosition);
            Vector2 shootDirection = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
            shootDirection.Normalize();
            bullet.GetComponent<Rigidbody2D>().velocity = shootDirection * shootSpeed;
            Destroy(bullet, bulletLifetime);
        }
    }
}
