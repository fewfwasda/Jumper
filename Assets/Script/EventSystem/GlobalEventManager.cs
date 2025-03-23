using UnityEngine;
using UnityEngine.Events;

public class GlobalEventManager : MonoBehaviour
{
    public static UnityEvent CollisionEnemy = new UnityEvent();
    public static void SendCollisionEnemy()
    {
        CollisionEnemy.Invoke();
    }
}
