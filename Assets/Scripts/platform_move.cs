using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform_move : MonoBehaviour
{
    Transform v;
    [SerializeField] float platform_speed ;
    [SerializeField] float max_up;
    [SerializeField] float max_down;
    bool up ;
    // Start is called before the first frame update
    void Start()
    {
        v = GetComponent<Transform>();
        up = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(v.position.y<= max_down)
        {
            up = true;
        }
        else if(v.position.y>= max_up)
        {
            up = false ;
        }

        if(up)
        {
            v.transform.position = new Vector3(v.position.x, v.position.y + platform_speed * Time.deltaTime, v.position.z);
        }
        else if(!up)
        {
            v.transform.position = new Vector3(v.position.x, v.position.y - platform_speed * Time.deltaTime, v.position.z);
        }
    }
}
