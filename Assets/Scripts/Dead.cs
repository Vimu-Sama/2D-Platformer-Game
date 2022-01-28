using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dead : MonoBehaviour
{

    private void Start()
    {
        an.SetBool("already_dead", false);
    }
    //[SerializeField] Canvas canvas;
    [SerializeField] Animator an;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Game Over!!!");
        an.SetBool("dead", true);
    }
    public void reverse()
    {
        SceneManager.LoadScene("Scene-1");
       // canvas.enabled = false;
    }


}
