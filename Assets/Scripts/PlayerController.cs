using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Animator an;
    [SerializeField] BoxCollider2D cd; 
    void Update()
    {
        Movement();
        Jump();
        Crouch();
    }


    void Movement()
    {
        float vel = Input.GetAxis("Horizontal");

        an.SetFloat("speed", Mathf.Abs(vel));
        Vector2 scale = transform.localScale;
        if (vel < 0)
        {
            scale.x = (-1) * Mathf.Abs(scale.x);
        }
        else if (vel > 0)
        {
            scale.x = Mathf.Abs(scale.x);
        }
        transform.localScale = scale;
    }

    void Jump()
    {
        float spe = Input.GetAxis("Vertical");
        an.SetFloat("ver_speed", spe);
    }

    void setfalsejmp()
    {
        an.SetFloat("ver_speed", 0);
    }

    void Crouch()
    {
        
        if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            an.SetBool("crch", true);
            cd.size = new Vector2(0.5198063f, 1.2f);
            cd.offset = new Vector2(-0.01084822f, 0.56f);
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            an.SetBool("crch", false);
            cd.size = new Vector2(0.5198063f, 2.07163f);
            cd.offset = new Vector2(-0.01084822f, 0.9851117f);
        }

    }


}
