using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound_script : MonoBehaviour
{
    AudioSource sound_device;
    [SerializeField] AudioClip sound_live;
    [SerializeField] AudioClip sound_dead;
    Animator an;
    bool con;
    private void Awake()
    {
        sound_device = GetComponent<AudioSource>();
        sound_device.PlayOneShot(sound_live);
        an = GetComponent<Animator>();
        con = true; 
    }

    private void Update()
    {
        if(an.GetBool("dead") && con)
        {
            Debug.Log("it worked");
            sound_device.PlayOneShot(sound_dead);
            con = false;
        }
    }
}
