using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform_move : MonoBehaviour
{
    Transform v;
    [SerializeField] float platform_speed ;
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
        
        if(v.position.y<= -2.46f)
        {
            up = true;
        }
        else if(v.position.y>= -0.38f)
        {
            up = false ;
        }

        if(up)
        {
            v.transform.position = new Vector2(v.position.x, v.position.y + platform_speed * Time.deltaTime);
        }
        else if(!up)
        {
            v.transform.position = new Vector2(v.position.x, v.position.y - platform_speed * Time.deltaTime);
        }
    }
}
