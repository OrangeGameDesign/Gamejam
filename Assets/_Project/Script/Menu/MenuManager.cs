using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
     public void Button_Play()
    {
        SceneManager.LoadScene(2);
    }

    public void EXIT()
    {
        Application.Quit();
    }
}











