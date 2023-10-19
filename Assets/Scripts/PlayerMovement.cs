using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10.0f;
    public float x_max, y_max, x_min, y_min;
    private float horizontal, vertical;
    private Rigidbody2D rb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        Vector2 newVelocity = new Vector2(horizontal, vertical);
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = speed * newVelocity;

        float newX, newY;

        newX = Mathf.Clamp(GetComponent<Rigidbody2D>().position.x, x_min, x_max);
        newY = Mathf.Clamp(GetComponent<Rigidbody2D>().position.y, y_min, y_max);

        GetComponent<Rigidbody2D>().position = new Vector2(newX, newY);
    }
}
