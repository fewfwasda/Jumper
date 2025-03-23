using UnityEngine;

public class GroundBlockEnemy : Enemy
{
    public override void Start()
    {
        base.Start();
        Damage = 1;
        Speed = 10;
    }
}
