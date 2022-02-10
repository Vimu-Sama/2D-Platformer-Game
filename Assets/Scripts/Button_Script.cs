using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Script : MonoBehaviour
{
    int current_level = 0;
    private void Awake()
    {
        current_level = PlayerPrefs.GetInt("current_level");
    }
    public void JumpToScene(int i)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(i);
    }

    public void Exit_Game()
    {
        Application.Quit();
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
