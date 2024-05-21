using System;
using UnityEngine;

public class GameMenusController : MonoBehaviour
{
    public static bool GameIsPaused = false;

    //Observer to handle reloading text in hud
    public event Action<bool> OnPauseGameChanged;

    [SerializeField]
    KeyCode PauseMenuKey = KeyCode.Escape;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(PauseMenuKey))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        GameIsPaused = false;
        Time.timeScale = 1.0f;

        OnPauseGameChanged?.Invoke(GameIsPaused);
    }

    void Pause()
    {
        GameIsPaused = true;
        Time.timeScale = 0.0f;

        OnPauseGameChanged?.Invoke(GameIsPaused);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
