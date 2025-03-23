using UnityEditor;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Character : MonoBehaviour
{
    protected int Speed;

    //две переменные прыжка для того, чтобы второй прыжок был слабее
    protected int JumpForce;
    protected int JumpForceCurrent;
    protected int MaxJumpCount;
    public int MaxHealth;

    protected Rigidbody Rb;

    private int _edgeMap = 28;
    private int _maxJumpCountCurrent;

    private float _horizontalInput;

    public static Character Instance;
    private void Awake()
    {
        Instance = this;
    }

    protected void Start()
    {
        MaxHealth = 3;
        MaxJumpCount = 1;
        JumpForce = 6;
        Speed = 10;
        Rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Move();
        Jump();
        EdgesMap();
    }
    private void Move()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * _horizontalInput * Speed * Time.deltaTime);
    }
    protected virtual void Jump()
    {
        if (_maxJumpCountCurrent >= 0 && Input.GetKeyDown(KeyCode.Space))
        {
            Rb.AddForce(Vector3.up * JumpForceCurrent, ForceMode.Impulse);
            _maxJumpCountCurrent--;
            JumpForceCurrent /= 2;
        }
    }
    private void EdgesMap()
    {
        if (transform.position.x > _edgeMap) transform.position = new Vector3(-_edgeMap, transform.position.y, 0);
        else if (transform.position.x < -_edgeMap) transform.position = new Vector3(_edgeMap, transform.position.y, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _maxJumpCountCurrent = MaxJumpCount;
            JumpForceCurrent = JumpForce;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            MaxHealth -= Enemy.Instance.Damage;
            GlobalEventManager.SendCollisionEnemy();
        }
    }
}