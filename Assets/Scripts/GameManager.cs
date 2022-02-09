using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private Button button;
    public string level;
    private Button_Script bs; 
    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(onclick);
        bs = FindObjectOfType<Button_Script>();
    }

    private void onclick()
    {
        level_status ls = LevelManager.Instance.getlevelstatus(level);
        if(level=="1")
        {
            LevelManager.Instance.setlevelstatus(level, level_status.unlocked);
        }
        switch(ls)
        {
            case level_status.locked:
                Debug.Log("Complete previous levels!!");
                break;
            case level_status.unlocked:
                Debug.Log("Able to play");
                int i = int.Parse(level);
                bs.JumpToScene(i);
                break;
            case level_status.completed:
                Debug.Log("Already Completed");
                break;
        }
    }



    /* int level;
    [Header("Buttons")]
    [SerializeField] List<GameObject> buttons= new List<GameObject>() ;
    // Start is called before the first frame update
    void Awake()
    {
        //PlayerPrefs.SetInt("current_level", 1);
        level = PlayerPrefs.GetInt("current_level");
        //Debug.Log(level);
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0;i<level;i++)
        {
            buttons[i].GetComponent<Button>().interactable = true;
            buttons[i].GetComponent<Animator>().enabled = true;
        }
    } */
}
