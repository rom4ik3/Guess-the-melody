using UnityEngine;
using UnityEngine.SceneManagement;


public class buttom : MonoBehaviour

{
   public void Gamestart ()
    {
        SceneManager.LoadScene("level");
    }
    public void Gameout()
    {
        Application.Quit();
    }
    public void Reset()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("startpanel");
           }
    public void Reversesong()
    {
        SceneManager.LoadScene("reverse");
    }
    public void Normal()
    {
        SceneManager.LoadScene("normal");
    }
    public void Backmenu()
    {
        SceneManager.LoadScene("startpanel");
    }
}


