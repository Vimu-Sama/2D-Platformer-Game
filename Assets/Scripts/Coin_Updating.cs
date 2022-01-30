using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Coin_Updating : MonoBehaviour
{
    public int coins;
    public TextMeshProUGUI score;
    private void Start()
    {
        coins = 0;
    }
    private void Update()
    {
        score.text = "Score: " + coins;
    }

}
