using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private static SoundManager instance;
    public static SoundManager Instance { get { return instance; } }

    public SoundType[] sounds;

    private void Awake()
    {
        if(instance==null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }

}

[Serializable]
public class SoundType
{
    Sounds soundtype;
    AudioClip audioclip;
}

public enum Sounds
{
    button_click,
    got_coin,
    lvl_start,
    lvl_complete,
    lvl_failed
}