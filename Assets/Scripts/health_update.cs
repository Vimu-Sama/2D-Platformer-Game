using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health_update : MonoBehaviour
{
    [SerializeField]  heart_destroy[] hearts = new heart_destroy[3];
    [SerializeField] Dead d;
    public int health;
    void Start()
    {
        health = 4;
    }

    private void Update()
    {
        reduce_health();
    }

    public void reduce_health()
    {
        switch(health)
        {
            case 0:
                d.heart_reached_zero = true;
                break;
            case 1:
                hearts[0].destroy_heart();
                break;
            case 2:
                hearts[1].destroy_heart();
                break;
            case 3:
                hearts[2].destroy_heart();
                break;
            default:
                break;
        }
    }
}
