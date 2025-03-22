using UnityEngine;

public class SphereCharacter : Character, IService
{
    protected new void Start()
    {
        MaxHealth = 5;
        MaxJumpCount = 2;
        JumpForce = 6;
        Speed = 100;
        Rb = GetComponent<Rigidbody>();
    }
}
