using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class CharacterHealthUI : MonoBehaviour
{
    private TextMeshProUGUI _healthUI;
    private void Awake()
    {
        GlobalEventManager.CollisionEnemy.AddListener(ChangeHealth);
    }
    private void Start()
    {
        _healthUI = GetComponent<TextMeshProUGUI>();
    }
    private void ChangeHealth()
    {
        var health = Character.Instance.MaxHealth;

        _healthUI.text = $"Health: {health}";
    }
}
