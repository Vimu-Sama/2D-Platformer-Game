using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    int level;
    [Header("Buttons")]
    [SerializeField] List<GameObject> buttons= new List<GameObject>() ;
    // Start is called before the first frame update
    void Awake()
    {
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
    }
}
