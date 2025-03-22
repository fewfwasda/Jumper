using UnityEngine;

public class GroundEnemy : Enemy, IService
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            TriggerOpetation();
        }
    }
    private void TriggerOpetation() { }
}
