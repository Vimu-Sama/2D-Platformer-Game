using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform_move_horizontal : MonoBehaviour
{
    [SerializeField] GameObject gb;
    [SerializeField] float speed;
    bool inside = false;
    

    private void Update()
    {
        if(inside)
        {
            if(gb.transform.position.x < 45.09f)
            {
                gb.transform.position = new Vector3(gb.transform.position.x+ Time.deltaTime, gb.transform.position.y, gb.transform.position.z);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        inside = true;
    }

}
