using UnityEditor;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Character : MonoBehaviour
{
    public int Speed;

    //две переменные прыжка для того, чтобы второй прыжок был слабее
    protected int JumpForce;
    protected int JumpForceCurrent;

    public int MaxJumpCount;
    public int MaxJumpCountCurrent;

    protected Rigidbody Rb;

    private int _edgeMap = 28;

    private float _horizontalInput;
    public static Character Instance;
    private void Awake()
    {
        Instance = this;
    }
    protected void Start()
    {
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
        if (MaxJumpCountCurrent >= 1 && Input.GetKeyDown(KeyCode.Space))
        {
            Rb.AddForce(Vector3.up * JumpForceCurrent, ForceMode.Impulse);
            MaxJumpCountCurrent--;
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
            MaxJumpCountCurrent = MaxJumpCount;
            JumpForceCurrent = JumpForce;
        }
    }
}