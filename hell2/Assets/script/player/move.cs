using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float sp = 5;
    public Rigidbody2D rb;
    Vector2 movement;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        rb.MovePosition(rb.position + movement.normalized * sp * Time.fixedDeltaTime);
    }
}