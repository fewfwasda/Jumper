using UnityEngine;

public class SphereCharacterHealth : CharacterHealth
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected new void Start()
    {
        MaxHealth = 5;
    }
}