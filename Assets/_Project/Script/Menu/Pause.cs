using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject Loading;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(PauseMenu.activeInHierarchy == true)
            {
                PauseMenu.SetActive(false);
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                Time.timeScale = 0;

            }
            else
            {
                PauseMenu.SetActive(true);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                Time.timeScale = 0;
            }
        }
    }
    public void BackButton()
    {
        PauseMenu.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
    }
    public void ExitButton()
    {
        Loading.SetActive(true);
    }
}
