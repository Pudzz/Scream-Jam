using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScript : MonoBehaviour
{
    private GameObject gameManager;
    private GameManagerScript managerScript;
   
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        managerScript = gameManager.GetComponent<GameManagerScript>();
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
