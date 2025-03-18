using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemy : MonoBehaviour
{
    protected int _speed = 10;

    private int _edgeMap = 28;
    private int _centreMap = 0;

    private Vector3 directionX;

    private void Start()
    {
        //выяснение в какую сторону держать путь препятствию
        if (transform.position.x > _centreMap) directionX = Vector3.left;
        else if (transform.position.x < _centreMap) directionX = Vector3.right;
    }
    private void Update()
    {
        MoveObstacle();
        DestroyOutOfBounds();
    }
    private void MoveObstacle()
    {
        transform.Translate(directionX * Time.deltaTime * _speed);
    }
    private void DestroyOutOfBounds()
    {
        if (transform.position.x > _edgeMap) Destroy(gameObject);
        else if (transform.position.x < -_edgeMap) Destroy(gameObject);
    }
}
