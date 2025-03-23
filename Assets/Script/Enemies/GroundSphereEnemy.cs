using UnityEngine;

public class GroundSphereEnemy : Enemy
{
    public override void Start()
    {
        base.Start();
        Damage = 2;
        Speed = 20;
    }
}
