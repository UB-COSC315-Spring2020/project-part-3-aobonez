using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    //Scoreing System
    public static int playerScore = 0;
    public Text ScoreText;

   

    private void Update()
    {
        ScoreText.text = playerScore.ToString();
        
        
    }

  

}
