using System.Collections;
using TriviaQuizGame.Types;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace TriviaQuizGame
{
    public class score : MonoBehaviour
    {
        public Text Normalscore;
        public Text Reversescore;
        void Start ()
        {

           Normalscore.text ="Normal level  " + PlayerPrefs.GetFloat("highnormal").ToString();
           Reversescore.text = "Reverse level  " + PlayerPrefs.GetFloat("highreverse").ToString();

        }

    }
    }

    

