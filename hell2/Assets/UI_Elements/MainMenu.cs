using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public GameObject optionsPopout;


    public void Play()
    {
        SceneManager.LoadScene("hell");
    }

    public void openOptions()
    {
        optionsPopout.SetActive(true);
    }

    public void closeOptions()
    {
        optionsPopout.SetActive(false);
    }

    public void BackToMain()
    {
        SceneManager.LoadScene("MainMenu");
    }


    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }


}
