using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject gameCanvas;
    private void Awake()
    {
        if(gameCanvas == null) { return; }
        if(SceneManager.GetActiveScene().buildIndex != 0) { gameCanvas.SetActive(false); return; }
        Time.timeScale = 0f;
    }
    public void PlayButton()
    {
        Time.timeScale = 1f;
    }
    public void PauseButton()
    {
        Time.timeScale = 0f;
    }
    public void ResumeButton()
    {
        Time .timeScale = 1f;
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("Level 1");
    }
}
