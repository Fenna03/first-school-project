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
    public void PlayGame ()
    {
        SceneManager.LoadScene("ball");
    }
    public void QuitGame ()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
