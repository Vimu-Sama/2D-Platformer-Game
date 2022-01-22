using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Animator an;
    [SerializeField] BoxCollider2D cd;
    [SerializeField] float speed;
    [SerializeField] float jmp;
    Rigidbody2D rb;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
      
        Movement();
        Jump();
        Crouch();
    }


    void Movement()
    {
        float horizontal = Input.GetAxis("Horizontal");

        an.SetFloat("speed", Mathf.Abs(horizontal));
        Vector2 scale = transform.localScale;
        if(horizontal!=0 && !an.GetBool("crch"))
        {
            if (horizontal < 0)
            {
                scale.x = (-1) * Mathf.Abs(scale.x);
            }
            else if (horizontal > 0)
            {
                scale.x = Mathf.Abs(scale.x);
            }
            float dist= speed * horizontal * Time.deltaTime;
            transform.position = new Vector3(transform.position.x + dist, transform.position.y, transform.position.z);

        }
        
        transform.localScale = scale;
    }

    void Jump()
    {
        float spe = Input.GetAxis("Vertical");
        if(spe>0)
        {
            rb.AddForce(new Vector2(0f, spe * jmp *Time.deltaTime), ForceMode2D.Impulse);
        }
        an.SetFloat("ver_speed", spe);
    }

    void setfalsejmp()
    {
        an.SetFloat("ver_speed", 0);
    }

    void Crouch()
    {
        Vector2 scale = transform.localScale;
        
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            an.SetBool("crch", true);
            cd.size = new Vector2(0.5198063f, 1.2f);
            cd.offset = new Vector2(-0.01084822f, 0.56f);
            if (Input.GetAxis("Horizontal") < 0)
            {
                scale.x = (-1) * Mathf.Abs(scale.x);
            }
            if (Input.GetAxis("Horizontal") > 0)
            {
                scale.x = Mathf.Abs(scale.x);
            } 
        } 
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            an.SetBool("crch", false);
            cd.size = new Vector2(0.5198063f, 2.07163f);
            cd.offset = new Vector2(-0.01084822f, 0.9851117f);
        }

    }


}
