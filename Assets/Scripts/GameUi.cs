using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUi : MonoBehaviour
{
    public void LoadMenu()
    { SceneManager.LoadScene("StartScreen"); }

    public void QuitApp()
    { Application.Quit(); }
}
