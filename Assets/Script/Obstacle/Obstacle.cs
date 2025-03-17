using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private int _position;
    private int _edge = 30;
    private int _speed;
    //вычисляем позицию куба, чтобы решить куда он будет направляться
    private void Start()
    {
        _speed = Random.Range(5, 15); // под сомнением
        Vector3 positionCube = transform.position;
        //позиция куба если он появился справа то = 1, если слева = 0
        if (transform.position.x > 0) _position = 1;
    }
    void Update()
    {
        DestroyOutOfBounds();
        MoveObstacle();
    }
    //в зависимости места спавна вычисляется направление препядствия
    private void MoveObstacle()
    {
        if (_position == 1)
        {
            transform.Translate(Vector3.left * Time.deltaTime * _speed);
        }
        else transform.Translate(Vector3.right * Time.deltaTime * _speed);
    }
    private void DestroyOutOfBounds()
    {
        if (transform.position.x > _edge) Destroy(gameObject);
        else if (transform.position.x < -_edge) Destroy(gameObject);
    }
}