using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 게임 시스템 싱글톤
public class GameSystem : MonoBehaviour
{
    public enum GameState
    {
        Ready,
        Play,
        Pause,
        Gameover
    }
    static GameSystem instance;
    public static GameSystem Instatce
    {
        get{
            return instance;
        }
    }
    public GameState G_state;
    public Text G_fail_text;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void GamePlayState(GameState state)
    {

        switch (state)
        {

            case GameState.Play:
                PlayGame();
                break;
            case GameState.Ready:
                ReadyGame();
                break;
            case GameState.Pause:
                PauseGame();
                break;
            case GameState.Gameover:
                GameOver();
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        GamePlayState(G_state);
    }
    void ReadyGame()
    {

    }
    void PlayGame()
    {

    }
    void PauseGame()
    {

    }
    void GameOver()
    {

    }
}

