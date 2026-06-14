using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager manager = FindObjectOfType<GameManager>();
            if (manager != null)
            {
                manager.CollectItem();
                Destroy(gameObject);
            }
        }
    }
}