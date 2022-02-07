using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public bool patrol;
    public bool turn;
    [SerializeField] float movespeed;
    [SerializeField] Transform ground_check;
    [SerializeField] LayerMask ground_layer ;
    [SerializeField] float flip_time;
    [SerializeField] Animator an;
    [SerializeField] Collider2D body;
    [SerializeField] health_update hu;
    float time;
    Rigidbody2D rb;
    private void Start()
    {
        patrol = true;
        turn = false;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (turn || body.IsTouchingLayers(ground_layer))
        {
            patrol = false;
            an.SetBool("walk", false);
            time += Time.deltaTime;
            if (time > flip_time)
            {
                transform.localScale = new Vector3(transform.localScale.x * (-1), transform.localScale.y, transform.localScale.z);
                movespeed *= -1;
                time = 0;
                patrol = true;
                turn = false;
                an.SetBool("walk", true);
            }
        }
        if (patrol)
        {
            rb.velocity= new Vector3(transform.position.x* movespeed * Time.fixedDeltaTime, transform.position.y, transform.position.z);
        }
        
    }

    private void FixedUpdate()
    {
        if(patrol)
        {
            turn = !(Physics2D.OverlapCircle(ground_check.position, 0.1f, ground_layer));
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag=="Player")
        {
            //Debug.Log("health deducted");
            hu.health -= 1;
        }
    }

}
