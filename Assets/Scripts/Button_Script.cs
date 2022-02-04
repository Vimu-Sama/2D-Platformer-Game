using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Script : MonoBehaviour
{
    public void JumpToScene(int i)
    {
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
}
