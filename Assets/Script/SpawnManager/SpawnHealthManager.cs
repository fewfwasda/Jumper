using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class SpawnHealthManager : MonoBehaviour
{
    public GameObject healthPrefabs;

    private int _minTimeToSpawnHealth;
    private int _maxTimeToSpawnHealth;

    private Vector3 _randomSpawnHealth;

    private int _edgeMapX = 28;
    private int _edgeMapY = 23;

    private void Awake()
    {
        GlobalEventManager.DeathPlayer.AddListener(StopSpawn);
    }

    private void Start()
    {
        _minTimeToSpawnHealth = 0;
        _maxTimeToSpawnHealth = 3;
        StartCoroutine(SpawnHealth());
    }
    private IEnumerator SpawnHealth()
    {
        while (true)
        {
            int randomPosX = Random.Range(-_edgeMapX, _edgeMapX);
            _randomSpawnHealth = new Vector3(randomPosX, _edgeMapY, 0);
            Instantiate(healthPrefabs, _randomSpawnHealth, Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(_minTimeToSpawnHealth, _maxTimeToSpawnHealth));
        }
    }
    private void StopSpawn()
    {
        Destroy(gameObject);
    }
}