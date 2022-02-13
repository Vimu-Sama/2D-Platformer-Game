using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Script : MonoBehaviour
{
    int current_level = 0;
    AudioSource audiosource ;
    [SerializeField] AudioClip sound;
    float time = 0f;
    bool cond = false;
    private void Awake()
    {
        current_level = PlayerPrefs.GetInt("current_level");
        cond = false;
        time = 0f;
        
        audiosource = GetComponent<AudioSource>();
    }

    
    public void JumpToScene(int i)
    {

        audiosource.PlayOneShot(sound) ;
        StartCoroutine(starting_first_coroutine(i));
        
    }

    IEnumerator starting_first_coroutine(int i)
    {
        
        Time.timeScale = 1;
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(i);

    }

    public void Exit_Game()
    {
        Application.Quit();
        audiosource.PlayOneShot(sound);
        Debug.Log("Player has quit the game");
    }


    public void deactivate_canvas(GameObject cv)
    {
        cv.SetActive(false);
    }

    public void special_jump()
    {
        SceneManager.LoadScene(current_level);
    }

}
