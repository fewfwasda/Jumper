using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject ScreenOfDeath;
    private bool _stopGame = false;
    private void Awake()
    {
        GlobalEventManager.DeathPlayer.AddListener(GameOver);
    }
    private void Update()
    {
        if (_stopGame) RestartGame();
    }
    private void GameOver()
    {
        _stopGame = true;
        DeadPLayer();
        GameOverScreen();
    }
    private void DeadPLayer()
    {
        CharacterHealth.Instance.MaxHealth = 0;
        Character.Instance.MaxJumpCount = 0;
        Character.Instance.MaxJumpCountCurrent = 0;
        Character.Instance.Speed = 0;
    }
    
    private void RestartGame()
    {
        if (Input.GetKeyDown(KeyCode.R)) SceneManager.LoadScene(1);
    }
    private void GameOverScreen()
    {
        ScreenOfDeath.SetActive(true);
    }
}