using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private static LevelManager instance;
    public static LevelManager Instance{ get {return instance ;}}
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public level_status getlevelstatus(string level)
    {
        level_status levelstatus= (level_status)PlayerPrefs.GetInt(level,0);
        return levelstatus;
    }

    public void setlevelstatus(string level, level_status levelstatus)
    {
        PlayerPrefs.SetInt(level, (int)levelstatus);
    }
}