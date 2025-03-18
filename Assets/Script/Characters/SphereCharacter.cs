using UnityEngine;

public class SphereCharacter : Character
{
    protected new void Start()
    {
         MaxJumpCount = 2;
        JumpForce = 6;
        Speed = 10;
        Rb = GetComponent<Rigidbody>();
    }
}
