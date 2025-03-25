using UnityEngine;

public class MedicineChest : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) PickUpHealth();
    }
    private void PickUpHealth()
    {
        if (CharacterHealth.Instance.MaxHealth + 1 < CharacterHealth.Instance.MaxHealth)
        {
            CharacterHealth.Instance.MaxHealth++;
            GlobalEventManager.SendPickUp();
        }
        Destroy(gameObject);
    }
}
