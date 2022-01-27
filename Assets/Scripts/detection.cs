using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detection : MonoBehaviour
{
    bool isGrounded = false;
    [SerializeField] GameObject gb;
    private void OnTriggerStay2D(Collider2D col)
    {
        if(col.gameObject.tag=="moving_land")
        {
            gb.transform.position = new Vector3(gb.transform.position.x + Time.deltaTime, gb.transform.position.y, gb.transform.position.z);
        }
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
