using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighScoreText : MonoBehaviour
{
    
    void Update()
    {
        GetComponent<TMP_Text>().SetText(MovingBlock.HighScore.ToString());
    }
}