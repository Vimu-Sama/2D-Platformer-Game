using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Got_Key : MonoBehaviour
{

    public int level = 0;
    private void OnTriggerEnter2D(Collider2D col)
    {
        PlayerPrefs.SetInt("current_level", level+1);
        LevelManager.Instance.setlevelstatus((level+1).ToString(), level_status.unlocked);
        SceneManager.LoadScene("Scene-2");
    }
}
