using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoScript : MonoBehaviour
{
    [SerializeField] private float jump;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y) < 0.001f)
        {
            Jump();
        }
    }

    private void Jump()
    {
        rb.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Enemy"))
        {
            SendMessageUpwards("Resetear");
        }
    }
}
