using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Got_Key : MonoBehaviour
{

    int level = 0;

    private void Start()
    {
        level = PlayerPrefs.GetInt("current_level"); 
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        level++;
        PlayerPrefs.SetInt("current_level", level);
        //Debug.Log(PlayerPrefs.GetInt("current_level"));
        SceneManager.LoadScene("Scene-2");
    }
}
