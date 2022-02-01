using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dead : MonoBehaviour
{
    bool load_scene = false;
    
    //[SerializeField] Canvas canvas;
    [SerializeField] Animator an;
    [SerializeField] float del ;
    float time;
    private void Start()
    {
        an.SetBool("already_dead", false);
        time = 0f;
    }


    private void Update()
    {
        if(load_scene)
        {
            time += Time.deltaTime;
        }
        if(time>=del)
        {
            //Debug.Log("worked here!");
            Scene s = SceneManager.GetActiveScene();
            SceneManager.LoadScene(s.name);
        }
        
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Game Over!!!");
        an.SetBool("dead", true);
        load_scene = true;
        
    }
    public void reverse()
    {
        SceneManager.LoadScene("Scene-1");
       // canvas.enabled = false;
    }


}
