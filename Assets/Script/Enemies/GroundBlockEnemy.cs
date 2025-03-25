using UnityEngine;

public class GroundBlockEnemy : Enemy
{
    private int _damage = 1;
    private int _speed = 10;
    private void Update()
    {
        MoveObstacle(_speed);
        DestroyOutOfBounds();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Attack(_damage);
        }
    }
}