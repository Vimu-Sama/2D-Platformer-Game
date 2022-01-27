using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detection : MonoBehaviour
{
    bool isGrounded = false;

    private void OnTriggerStay2D(Collider2D col)
    {
        isGrounded = true;
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        isGrounded = false;
    }

    public bool getboolean()
    {
        return isGrounded;
    }

}
