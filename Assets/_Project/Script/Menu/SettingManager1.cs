using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingManager1 : MonoBehaviour
{
     public void Button_Setting()
    {
        SceneManager.LoadScene(1);
    }
    public void QualityLevel(int _int)
    {
        QualitySettings.SetQualityLevel(_int);

    }
    public void Fullscreen(bool _bool)
    {
        Screen.fullScreen = _bool; 
    }
}












