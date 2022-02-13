using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class got_coin : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Coin_Updating cp;
    [SerializeField] Animator an;
    [SerializeField] AudioClip sound;
    AudioSource sound_manager;
    private void Start()
    {
        cp = FindObjectOfType<Coin_Updating>();
        sound_manager = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            sound_manager.PlayOneShot(sound);
            cp.coins += 1;
            an.SetBool("coin_flip", true);
            //Debug.Log("COIN WORKED-->   "+ an.GetBool("coin_flip"));

        }
    }

    void Destroy_coin()
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, -6);
        StartCoroutine( worked());
    }

    IEnumerator worked()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}
