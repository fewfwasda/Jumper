using UnityEngine;

public class SphereCharacter : Character
{
    protected new void Start()
    {
        MaxHealth = 5;
        MaxJumpCount = 2;
        JumpForce = 6;
        Speed = 50;
        Rb = GetComponent<Rigidbody>();
    }
}
