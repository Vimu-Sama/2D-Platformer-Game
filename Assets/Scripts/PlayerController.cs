using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Animator an;
    [SerializeField] BoxCollider2D cd;
    [SerializeField] float speed;
    [SerializeField] float jmp;
    [SerializeField] detection det;
   // [SerializeField] bool isGrounded = true;
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
        an.SetBool("run", det.getboolean());
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
        if(Input.GetKeyDown(KeyCode.W) && det.getboolean())
        {
            rb.velocity = new Vector2(0, jmp);
            an.SetBool("jmp", true);
            //isGrounded = false;
        }
        
        

    }


    void setfalsejmp()
    {
        an.SetBool("jmp", false);
       // isGrounded = true ;
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
