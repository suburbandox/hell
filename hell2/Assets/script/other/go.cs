using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class go : MonoBehaviour
{
    public string s;

    public void gg()
    {
        SceneManager.LoadScene(s);
    }
}
