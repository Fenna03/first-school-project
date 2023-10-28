using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public GameObject Explosion1;

    public void Start()
    {
        GameObject.FindGameObjectWithTag("gameMusic").GetComponent<MusicClass>().PlayMusic();
        
    }

    //starts gameMode
    public void PlayGame (int gameMode = 0)
    {
        if (gameMode == 0)
        {
            Instantiate(Explosion1, new Vector3(0, 0, 5), Quaternion.identity);
            DontDestroyOnLoad(Instantiate(Explosion1, new Vector3(0, 0, 5), Quaternion.identity));
            // enable explosion
            // callback function 
           
            SceneManager.LoadScene("ball");
        }
        if (gameMode == 1)
        {
            Instantiate(Explosion1, new Vector3(0, 0, 0), Quaternion.identity);
            DontDestroyOnLoad(Instantiate(Explosion1, new Vector3(0, 0, 5), Quaternion.identity));
            SceneManager.LoadScene("reverse");
        }
        if (gameMode == 2)
        {
            Instantiate(Explosion1, new Vector3(0, 0, 0), Quaternion.identity);
            DontDestroyOnLoad(Instantiate(Explosion1, new Vector3(0, 0, 5), Quaternion.identity));
            SceneManager.LoadScene("all ways");
        }
        if (gameMode == 3)
        {
            Instantiate(Explosion1, new Vector3(0, 0, 0), Quaternion.identity);
            DontDestroyOnLoad(Instantiate(Explosion1, new Vector3(0, 0, 5), Quaternion.identity));
            SceneManager.LoadScene("1-player");
        }
        if (gameMode == 4)
        {
            Instantiate(Explosion1, new Vector3(0, 0, 0), Quaternion.identity);
            DontDestroyOnLoad(Instantiate(Explosion1, new Vector3(0, 0, 5), Quaternion.identity));
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
        Instantiate(Explosion1, new Vector3(0, 0, 0), Quaternion.identity);
        Debug.Log("Quit");
        Application.Quit();
    }
    public void ResetGame()
    {
        Instantiate(Explosion1, new Vector3(0, 0, 0), Quaternion.identity);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
