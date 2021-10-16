using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManagerScript : MonoBehaviour
{
    public enum MenuState
    {
        Default, MainMenu, Game, GameOver, Win, LoadingScreen
    };

    public enum  GameState
    {
        Default, Play, Paus, End, Menu
    };

    private float loadingTime = 5;

    private MenuState m_menuState = MenuState.Default;
    private GameState m_gameState = GameState.Default;

    static GameManagerScript instance;

    void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        m_menuState = MenuState.LoadingScreen;
        m_gameState = GameState.Play;
        
    }

    // Update is called once per frame
    void Update()
    {
        // Switch statements for switching between the scenes
        switch(m_menuState)
        {
            case MenuState.MainMenu:
                if (SceneManager.GetActiveScene().name != "MainMenuScene")
                {
                    SceneManager.LoadScene(1);
                }
                break;

            case MenuState.Game:
                if(SceneManager.GetActiveScene().name != "GameScene")
                {
                    SceneManager.LoadScene(2);
                }
                break;

            case MenuState.GameOver:
                if (SceneManager.GetActiveScene().name != "GameOverScene")
                {
                    SceneManager.LoadScene(3);
                }
                break;

            case MenuState.LoadingScreen:
                if (SceneManager.GetActiveScene().name != "LoadingScene")
                {
                    SceneManager.LoadScene(0);
                }
                else
                {
                    loadingTime -= Time.deltaTime;
                    if(loadingTime <= 0)
                    {
                        m_menuState = MenuState.MainMenu;
                    }
                }
                break;
        }

        // Switch statements for pausing, unpausing and ending the game
        switch(m_gameState)
        {
            case GameState.Paus:
                // paus
                break;

            case GameState.Play:
                // play
                break;

            case GameState.End:
                // end
                break;
        }
    }

    public void UpdateGameState(GameState p_gameState)
    {
        m_gameState = p_gameState;
    }

    public void UpdateMenuState(MenuState p_menuState)
    {
        m_menuState = p_menuState;
    }
}
