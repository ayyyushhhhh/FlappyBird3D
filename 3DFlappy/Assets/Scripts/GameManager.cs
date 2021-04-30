using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;
    private void Awake()
    {
        Screen.SetResolution(1080, 1920, true);
    }
    public void Pause()
    {
        if (Time.timeScale != 0f&&pausePanel!=null)
        {
            Time.timeScale = 0f;
            pausePanel.SetActive(true);
        }
        
    }
    public void Resume()
    {
        if (pausePanel != null)
        {
            pausePanel.SetActive(false);
            Time.timeScale = 1f;
        }
        
    }

    public void menu()
    {
       SceneManager.LoadScene("Menu");
    }

    public void Replay()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level 1");
    }
    
}
