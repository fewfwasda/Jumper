using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    private Rigidbody _rb;
    private int _speed = 3;
    private int _jumpForce = 6;
    private int _maxJumpCountCurrent;
    private float _horizontalInput;
    private int _edgeMap = 28;
    public bool isDead;
    int coinCollected;
    public static PlayerController singleton { get; private set; }
    public event OnCoinTake onCoinTake;
    public delegate void OnCoinTake(int totalCoins);
    private void Awake()
    {
        singleton = this;
    }
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        isDead = false;
    }

    void FixedUpdate()
    {
        Move();
        Jump();
        EdgesMap();
    }
    //края карты, за которые нельзя выходить игроку
    private void EdgesMap()
    {
        if (transform.position.x > _edgeMap) transform.position = new Vector3(-_edgeMap, transform.position.y, 0);
        else if (transform.position.x < -_edgeMap) transform.position = new Vector3(_edgeMap, transform.position.y, 0);
    }
    private void Move()
    {
        _horizontalInput = Input.GetAxis("Horizontal");

        //_rb.AddForce(Vector3.right.normalized * _horizontalInput * _speed);
        transform.Translate(Vector3.right * _horizontalInput * _speed * Time.deltaTime);
    }
    private void Jump()
    {

        if (_maxJumpCountCurrent > 0 && Input.GetKeyDown(KeyCode.Space))
        {
            _rb.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
            _maxJumpCountCurrent--;
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            _maxJumpCountCurrent = 1;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            isDead = true;
        }
        if (other.gameObject.CompareTag("Coin"))
        {
            onCoinTake.Invoke(coinCollected);
            coinCollected++;
        }
    }
}