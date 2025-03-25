using UnityEngine;

public class CharacterHealth : MonoBehaviour
{
    public int MaxHealth { get; set; }
    protected int CurrentHealth;

    public static CharacterHealth Instance;
    private void Awake()
    {
        Instance = this;
    }
    protected void Start()
    {
        MaxHealth = 3;
    }
}