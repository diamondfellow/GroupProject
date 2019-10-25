using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprint : MonoBehaviour
{
    public float SprintTimer = 4;
    public float moveSpeed = 5;
    public bool exausted = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //bool still = false;
        if (Input.GetKey(KeyCode.LeftShift) && SprintTimer >= 0)
        {
            SprintTimer -= Time.deltaTime;
            Vector3 mousePosition = Input.mousePosition;
            //mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            //mousePosition.z = transform.position.z;
            //transform.up = mousePosition - transform.position;
            float x = Input.GetAxisRaw("Horizontal");
            float y = Input.GetAxisRaw("Vertical");
            Vector2 moveDir = x * transform.right + y * transform.up;
            moveDir.Normalize();
            GetComponent<Rigidbody2D>().velocity = moveDir * moveSpeed * 2;

            if (SprintTimer < 0)
            {
                exausted = true;
            }
        }
        else if ( SprintTimer < 4 && exausted)
        {
            SprintTimer += Time.deltaTime;
            Vector3 mousePosition = Input.mousePosition;
            //mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            //mousePosition.z = transform.position.z;
            //transform.up = mousePosition - transform.position;
            float x = Input.GetAxisRaw("Horizontal");
            float y = Input.GetAxisRaw("Vertical");
            Vector2 moveDir = x * transform.right + y * transform.up;
            moveDir.Normalize();
            GetComponent<Rigidbody2D>().velocity = moveDir * moveSpeed / 16;
        }
        else
        {

            SprintTimer += Time.deltaTime;
            if (SprintTimer > 4)
            {
                SprintTimer = 4;
                exausted = false;
            }
            Vector3 mousePosition = Input.mousePosition;
            //mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            //mousePosition.z = transform.position.z;
            //transform.up = mousePosition - transform.position;
            float x = Input.GetAxisRaw("Horizontal");
            float y = Input.GetAxisRaw("Vertical");
            Vector2 moveDir = x * transform.right + y * transform.up;
            moveDir.Normalize();
            GetComponent<Rigidbody2D>().velocity = moveDir * moveSpeed;
        }
    }
}