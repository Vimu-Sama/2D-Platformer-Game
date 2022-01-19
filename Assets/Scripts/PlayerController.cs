using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Animator an;
    
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
        if(Input.GetKeyDown(KeyCode.Space))
        {
            an.SetBool("jmp", true);
        }

    }

    void setfalsejmp()
    {
        an.SetBool("jmp", false);
    }

    void Crouch()
    {
        if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            an.SetBool("crch", true);
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            an.SetBool("crch", false);
        }

    }


}
