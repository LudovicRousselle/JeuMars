using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private void Start()
    {
        
    }

    void PlayWithDelay()
    {
        Invoke("Play", 2);
    }

    void play()
    {
        SceneManager.LoadScene("main");
    }
    void Quit()
    {
        Application.Quit();
    }
}
