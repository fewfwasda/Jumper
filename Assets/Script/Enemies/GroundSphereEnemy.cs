using UnityEngine;

public class GroundSphereEnemy : Enemy
{
    private int _damage = 2;
    private int _speed = 20;
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