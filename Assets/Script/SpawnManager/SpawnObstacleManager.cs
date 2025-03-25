using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class SpawnObstacleManager : MonoBehaviour
{
    public List<GameObject> obstaclesPrefabs = new List<GameObject>();

    private int _minTimeToSpawnObstacle;
    private int _maxTimeToSpawnObstacle;

    private Vector3 _leftEdgeSpawn = new Vector3(-28, 1, 0);
    private Vector3 _rigthEdgeSpawn = new Vector3(28, 1, 0);

    public static SpawnObstacleManager Instance;

    private void Awake()
    {
        GlobalEventManager.DeathPlayer.AddListener(StopSpawn);
    }

    private void Start()
    {
        _minTimeToSpawnObstacle = 0;
        _maxTimeToSpawnObstacle = 7;
        StartCoroutine(SpawnObstacle());
    }
    //рандомно вычисляем с какой стороны появится куб
    private Vector3 LeftEdgeOrRight()
    {
        int getEdge = Random.Range(0, 2);
        if (getEdge == 0) return _leftEdgeSpawn;
        return _rigthEdgeSpawn;
    }
    private IEnumerator SpawnObstacle()
    {
        while (true)
        {
            int indexObstacle = Random.Range(0, obstaclesPrefabs.Count);
            Instantiate(obstaclesPrefabs[indexObstacle], LeftEdgeOrRight(), Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(_minTimeToSpawnObstacle, _maxTimeToSpawnObstacle));
        }
    }
    private void StopSpawn()
    {
        Destroy(gameObject);
    }
}