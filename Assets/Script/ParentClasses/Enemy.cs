using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemy : MonoBehaviour, IService
{
    protected int Speed = 10;
    public int Damage;
    private int _edgeMap = 28;
    private int _centreMap = 0;

    private Vector3 directionX;

    private void Start()
    {
        Damage = 1;
        //вы€снение в какую сторону держать путь преп€тствию
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
        transform.Translate(directionX * Time.deltaTime * Speed);
    }
    private void DestroyOutOfBounds()
    {
        if (transform.position.x > _edgeMap) Destroy(gameObject);
        else if (transform.position.x < -_edgeMap) Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("«дфнук"))
        {
            DealDamage(Damage);
        }
    }
    private void DealDamage(int damage)
    {
        SphereCharacter. -= damage;
        Debug.Log(MaxHealth);
    }
}
