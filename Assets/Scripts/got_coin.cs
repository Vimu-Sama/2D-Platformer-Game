using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class got_coin : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("got it!!");
            Destroy(gameObject);
        }
    }
}
