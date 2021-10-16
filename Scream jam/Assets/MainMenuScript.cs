using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScript : MonoBehaviour
{
    private GameObject gameManager;
    private GameManagerScript managerScript;

    private GameObject optionsMenu;
    private GameObject storyMenu;
   
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        managerScript = gameManager.GetComponent<GameManagerScript>();

        optionsMenu = GameObject.Find("Options");
        storyMenu = GameObject.Find("Story");
    }

    public void PlayGame()
    {
        managerScript.UpdateMenuState(GameManagerScript.MenuState.Game);
    }

    public void ExitGame()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }
}
