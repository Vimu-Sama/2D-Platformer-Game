using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform_move_horizontal : MonoBehaviour
{
    [SerializeField] GameObject gb;
    [SerializeField] float speed;
    [SerializeField] float max_right;
    [SerializeField] float max_left;
    [SerializeField] string s;
    [SerializeField] bool no_trigger;
    bool inside = false;
    bool move = true;
    private bool left;

    private void Update()
    {
        if((no_trigger || inside)&& move)
        { 
            if (left)
            {
                gb.transform.position = new Vector3(gb.transform.position.x - Time.deltaTime, gb.transform.position.y, gb.transform.position.z);
            }
            else
            {
                gb.transform.position = new Vector3(gb.transform.position.x + Time.deltaTime, gb.transform.position.y, gb.transform.position.z);
            }
        }
        

        if(no_trigger)
        {
            move = true;
            if (s == "move right")
            {
                if (gb.transform.position.x < max_right)
                {
                    left = false;
                }
                else
                    move = false;
            }
            else if (s == "move left")
            {
                if (gb.transform.position.x > max_left)
                {
                    left = true;
                    //gb.transform.position = new Vector3(gb.transform.position.x - Time.deltaTime, gb.transform.position.y, gb.transform.position.z);
                }
                else
                    move = false;
            }
            else if (s == "both")
            {
                if (gb.transform.position.x > max_right)
                {
                    left = true;
                    //gb.transform.position = new Vector3(gb.transform.position.x + Time.deltaTime, gb.transform.position.y, gb.transform.position.z);
                }
                else if (gb.transform.position.x < max_left)
                {
                    left = false;
                    //gb.transform.position = new Vector3(gb.transform.position.x - Time.deltaTime, gb.transform.position.y, gb.transform.position.z);
                }
            }
        }
        else if(inside)
        {
            if(s=="move right")
            {
                if (gb.transform.position.x < max_right)
                {
                    left = false;
                    //gb.transform.position = new Vector3(gb.transform.position.x + Time.deltaTime, gb.transform.position.y, gb.transform.position.z);
                }
                else
                    move = false;
            }
            else if(s=="move left")
            {
                if (gb.transform.position.x > max_left)
                {
                    left = true;
                    //gb.transform.position = new Vector3(gb.transform.position.x - Time.deltaTime, gb.transform.position.y, gb.transform.position.z);
                }
                else
                    move = false;
            }
            else if(s=="both")
            {
                if (gb.transform.position.x > max_right)
                {
                    left = true;
                    //gb.transform.position = new Vector3(gb.transform.position.x + Time.deltaTime, gb.transform.position.y, gb.transform.position.z);
                }
                else if (gb.transform.position.x < max_left)
                {
                    left = false;
                    //gb.transform.position = new Vector3(gb.transform.position.x - Time.deltaTime, gb.transform.position.y, gb.transform.position.z);
                }
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        inside = true;
    }

}
