using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    Rigidbody2D rb;
    float playerInput;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Player2Movement();
    }

    void Player2Movement()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity = new Vector2(0, speed);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = new Vector2(0, -speed);
        }
        else
        {
            rb.velocity = new Vector2(0, 0);
        }
    }
}
