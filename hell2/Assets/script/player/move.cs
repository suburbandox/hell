using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float sp = 5;
    public Animator ana;
    public float v;

    Rigidbody2D rb;

    Vector2 movement;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        if (movement.x == 0 && movement.y == 0)
        {
            ana.SetBool("run", false);
        }
        else
        {
            ana.SetBool("run", true);
        }
    }

    void FixedUpdate()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        rb.MovePosition(rb.position + movement.normalized * sp * Time.fixedDeltaTime);
    }
}