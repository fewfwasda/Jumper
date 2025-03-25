using UnityEngine;
using UnityEngine.Events;

public class GlobalEventManager : MonoBehaviour
{
    public static UnityEvent CollisionEnemy = new UnityEvent();
    public static UnityEvent DeathPlayer = new UnityEvent();
    public static UnityEvent PickUp = new UnityEvent();
    public static void SendCollisionEnemy()
    {
        CollisionEnemy.Invoke();
    }
    public static void SendDeathPlayer()
    {
        DeathPlayer.Invoke();
    }
    public static void SendPickUp()
    {
        PickUp.Invoke();
    }
}