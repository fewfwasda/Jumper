using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
[RequireComponent(typeof(Rigidbody))]
public class Enemy : MonoBehaviour
{
    public int Speed;
    public int Damage;
    public int _edgeMap = 28;
    public int _centreMap = 0;

    private Vector3 directionX;

    public static Enemy Instance;
    private void Awake()
    {
        Instance = this;
    }
    public virtual void Start()
    {
        Damage = 1;
        Speed = 10;
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
        transform.Translate(directionX * Time.deltaTime * Speed);
    }
    private void DestroyOutOfBounds()
    {
        if (transform.position.x > _edgeMap) Destroy(gameObject);
        else if (transform.position.x < -_edgeMap) Destroy(gameObject);
    }
}
