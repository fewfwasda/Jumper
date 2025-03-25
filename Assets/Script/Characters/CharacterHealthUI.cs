using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class CharacterHealthUI : MonoBehaviour
{
    private TextMeshProUGUI _healthUI;
    private int _health;
    private void Awake()
    {
        GlobalEventManager.CollisionEnemy.AddListener(ChangeHealth);
        GlobalEventManager.DeathPlayer.AddListener(ChangeHealth);
        GlobalEventManager.PickUp.AddListener(ChangeHealth);
    }
    private void Start()
    {
        _healthUI = GetComponent<TextMeshProUGUI>();
        _health = CharacterHealth.Instance.MaxHealth;
        _healthUI.text = $"Health: {_health}";
    }
    private void ChangeHealth()
    {
        _health = CharacterHealth.Instance.MaxHealth;
        _healthUI.text = $"Health: {_health}";
    }
}