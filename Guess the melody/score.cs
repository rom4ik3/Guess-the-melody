using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class score : MonoBehaviour
{
     internal float highScore = 0;
    void Start()
    {
       // highScore = PlayerPrefs.GetFloat(SceneManager.GetActiveScene().name, 0);
        score.Find("ScoreTexts/TextHighScore").GetComponent<Text>().text = highScore.ToString();
    }
    
			
}
