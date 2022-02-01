using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart_destroy : MonoBehaviour
{
    Animator an;


    private void Start()
    {
        an = GetComponent<Animator>();
    }

    public void destroy_heart()
    {
        an.SetBool("break_heart", true);
    }
}
