using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneControler : MonoBehaviour
{
    public void sahneyeYonlen(string sahneAdi)
    {
        SceneManager.LoadScene(sahneAdi);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
