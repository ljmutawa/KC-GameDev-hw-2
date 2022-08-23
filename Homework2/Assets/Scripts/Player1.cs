using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
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
        Player1Movement();
    }

    void Player1Movement()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(0, speed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(0, -speed);
        }
        else
        {
            rb.velocity = new Vector2(0, 0); 
        }
    }
}

