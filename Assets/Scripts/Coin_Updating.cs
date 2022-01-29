using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Updating : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            Debug.Log("got it!!");
            Destroy(gameObject);
        }
    }
}
