using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {
    
    public GameObject pauseMenu , PauseButton;


    public void pause()
    {
        PauseButton.SetActive(false);
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void Resume()
    {
 
        PauseButton.SetActive(true);
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
}
