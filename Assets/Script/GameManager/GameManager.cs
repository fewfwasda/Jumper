using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ScreenOfDeath;
    private void Awake()
    {
        GlobalEventManager.CollisionEnemy.AddListener(ChangeHealthSFX);
        GlobalEventManager.CollisionEnemy.AddListener(StopGame);
    }
    private void ChangeHealthSFX()
    {
        Debug.Log("SFXDamage");
    }
    private void StopGame()
    {
        if (Character.Instance.MaxHealth <= 0)
        {
            ScreenOfDeath.SetActive(true);
        }
    }
}
