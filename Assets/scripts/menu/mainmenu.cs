using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public void Start()
    {
        GameObject.FindGameObjectWithTag("gameMusic").GetComponent<MusicClass>().PlayMusic();
    }

    //starts gameMode
    public void PlayGame (int gameMode = 0)
    {
        if (gameMode == 0)
        {
            SceneManager.LoadScene("ball");
        }
        if (gameMode == 1)
        {
            SceneManager.LoadScene("reverse");
        }
        if (gameMode == 2)
        {
            SceneManager.LoadScene("all ways");
        }
        if (gameMode == 3)
        {
            SceneManager.LoadScene("1-player");
        }
        if (gameMode == 4)
        {
            SceneManager.LoadScene("breakout");
        }
        if(gameMode == 5)
        {
            SceneManager.LoadScene("start menu");
        }
    }

    //quits gameMode
    public void QuitGame ()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
