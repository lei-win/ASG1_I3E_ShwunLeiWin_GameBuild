using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioSource playerAudio = other.GetComponent<AudioSource>();
            if (playerAudio != null)
            {
                playerAudio.Play();
            }

            GameManager manager = FindObjectOfType<GameManager>();
            if (manager != null)
            {
                manager.CollectItem();
                Destroy(gameObject);
            }
        }
    }
}