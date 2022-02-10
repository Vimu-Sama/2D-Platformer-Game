using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detection : MonoBehaviour
{
    bool isGrounded = false;
    float prev = 0;
    [SerializeField] GameObject gb;

    private void OnTriggerStay2D(Collider2D col)
    {
        
        if(col.gameObject.tag=="moving_land")
        {
            if ((col.gameObject.transform.position.x - prev) > 0)
            {
                gb.transform.position = new Vector3(gb.transform.position.x + Time.deltaTime, gb.transform.position.y, gb.transform.position.z);
            }
            else
            {
                gb.transform.position = new Vector3(gb.transform.position.x - Time.deltaTime, gb.transform.position.y, gb.transform.position.z);
            }
            prev = col.gameObject.transform.position.x;
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
