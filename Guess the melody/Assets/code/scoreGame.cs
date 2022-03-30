using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TriviaQuizGame;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace TriviaQuizGame
{
public class scoreGame : MonoBehaviour
  {
    public float highScore = 0;
    private Transform score;
   void Start()
    {
       highScore = PlayerPrefs.GetFloat(SceneManager.GetActiveScene().name + 0);
       score.GetComponent<Text>().text =  highScore.ToString();
    }

  }
}
