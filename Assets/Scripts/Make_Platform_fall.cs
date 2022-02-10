using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Make_Platform_fall : MonoBehaviour
{
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponentInParent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        rb.velocity = new Vector3(0f, -50f, 0f);
        rb.gravityScale = 1;
    }
}
