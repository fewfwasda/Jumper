using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private int _position;
    private int _edge = 30;
    private int _speed;
    //��������� ������� ����, ����� ������ ���� �� ����� ������������
    private void Start()
    {
        _speed = Random.Range(5, 15); // ��� ���������
        Vector3 positionCube = transform.position;
        //������� ���� ���� �� �������� ������ �� = 1, ���� ����� = 0
        if (transform.position.x > 0) _position = 1;
    }
    void Update()
    {
        DestroyOutOfBounds();
        MoveObstacle();
    }
    //� ����������� ����� ������ ����������� ����������� �����������
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