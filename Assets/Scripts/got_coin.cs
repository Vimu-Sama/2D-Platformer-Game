using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class got_coin : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Coin_Updating cp;
    [SerializeField] Animator an;
    private void Start()
    {
        cp = FindObjectOfType<Coin_Updating>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            cp.coins += 1;
            an.SetBool("coin_flip", true);
            //Debug.Log("COIN WORKED-->   "+ an.GetBool("coin_flip"));
            

        }
    }

    void Destroy_coin()
    {
        Destroy(gameObject);
    }

}
