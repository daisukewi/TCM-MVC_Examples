using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenuController : MonoBehaviour
{
    public GameMenusController MenuControllerComponent;
    public GameObject PauseMenuPanel;


    // Start is called before the first frame update
    void Start()
    {
        MenuControllerComponent.OnPauseGameChanged += TogglePauseMenu;
    }

    void TogglePauseMenu(bool isGamePaused)
    {
        PauseMenuPanel.SetActive(isGamePaused);
    }
}
