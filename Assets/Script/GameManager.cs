using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

//public class GameManager : MonoBehaviour
//{
    //public GameObject screenOfDeath;
    //private float _seconds;
    //private int _timeForReductionSpawnObstacles; //переменная предназначена для уменьшение времени спавна препядствий каждые 20 секунд
    //private SpawnObstacle _spawnObstacle;

    //public static GameManager singleton { get; private set; }
    //public event TimeSurvived timeSurvivedEvent;
    //public delegate void TimeSurvived(int seconds);
    //private void Awake()
    //{
    //    singleton = this;
    //}
    //void Start()
    //{
    //    _seconds = 0;
    //    _timeForReductionSpawnObstacles = 20;
    //    //_spawnObstacle = GameObject.Find("SpawnObstacle").GetComponent<SpawnObstacle>();
    //}
    //private void Update()
    //{
    //    Timer();
    //    RestartGame();
    //    Dead();
    //    //ReductionSpawnObstacles();
    //}
    //private void Timer()
    //{
    //    _seconds += Time.deltaTime;
    //    timeSurvivedEvent.Invoke((int)_seconds);
    //}
    //private void ReductionSpawnObstacles()
    //{
    //    if (_seconds > _timeForReductionSpawnObstacles)
    //    {
    //        _spawnObstacle.maxTimeToSpawnObstacle--;
    //        _timeForReductionSpawnObstacles += 10;
    //    }
    //}
    //private void RestartGame()
    //{
    //    if (PlayerController.singleton.isDead && Input.GetKeyDown(KeyCode.R))
    //    {
    //        PlayerController.singleton.isDead = false;
    //        Time.timeScale = 1;
    //        SceneManager.LoadScene(0);
    //    }
    //}
    //private void Dead()
    //{
    //    if (PlayerController.singleton.isDead)
    //    {
    //        screenOfDeath.gameObject.SetActive(true);
    //        Time.timeScale = 0;
    //    }
    //}
//}
