using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class got_coin : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Coin_Updating cp;

    private void Start()
    {
        cp = FindObjectOfType<Coin_Updating>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            cp.coins += 1;
            Destroy(gameObject);
        }
    }
}
