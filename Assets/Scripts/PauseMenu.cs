using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject panel;
    public static bool paused = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.F10) && !paused)
        {
            Time.timeScale = 0f;
            panel.SetActive(true);
            paused = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.F10) && paused)
        {
            Time.timeScale = 1f;
            panel.SetActive(false);
            paused = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
    private void Start()
    {
        panel.SetActive(false);
    }
    public void Resume()
    {
        Time.timeScale = 1f;
        panel.SetActive(false);
        paused = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void Settings()
    {

    }
    public void Quit()
    {
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1f;
        paused = false;
    }
}