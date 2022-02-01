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
    public bool heart_reached_zero;
    float time;
    private void Start()
    {
        an.SetBool("already_dead", false);
        heart_reached_zero = false;
        time = 0f;
    }


    private void Update()
    {
        if(heart_reached_zero)
        {
            Debug.Log("the heart reached zero also worked");
            an.SetBool("dead", true);
            load_scene = true;
        }
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
