using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public static void Play()
    { SceneManager.LoadScene("GameScene"); }

    public static void Customisation()
    { SceneManager.LoadScene("CustomisationScene"); }
}