using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private PlayerController _playerController;
    public GameObject screenOfDeath;
    public TextMeshProUGUI timerText;
    private float _timer;
    private int _timeForReductionSpawnObstacles; //переменная предназначена для уменьшение времени спавна препядствий каждые 20 секунд
    private SpawnObstacle _spawnObstacle;
    void Start()
    {
        _timer = 0;
        _timeForReductionSpawnObstacles = 20;
        //_spawnObstacle = GameObject.Find("SpawnObstacle").GetComponent<SpawnObstacle>();
        //_playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    private void Update()
    {
        //Timer();
        RestartGame();
        Dead();
        //ReductionSpawnObstacles();
    }
    private void Timer()
    {
        _timer += Time.deltaTime;
        timerText.text = $"Time: {(int)_timer}";
    }
    private void ReductionSpawnObstacles()
    {
        if (_timer > _timeForReductionSpawnObstacles)
        {
            _spawnObstacle.maxTimeToSpawnObstacle--;
            _timeForReductionSpawnObstacles += 10;
        }
    }
    private void RestartGame()
    {
        if (PlayerController.singleton.isDead && Input.GetKeyDown(KeyCode.R))
        {
            PlayerController.singleton.isDead = false;
            Time.timeScale = 1;
            SceneManager.LoadScene(0);
        }
    }
    private void Dead()
    {
        if (PlayerController.singleton.isDead)
        {
            screenOfDeath.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
