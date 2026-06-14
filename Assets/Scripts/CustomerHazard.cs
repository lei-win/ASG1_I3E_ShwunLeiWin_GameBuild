using UnityEngine;

public class CustomerHazard : MonoBehaviour
{
    public Vector3 targetOffset;
    public float speed = 2f;
    public int patienceDamage = 1;

    private Vector3 startPosition;
    private Vector3 targetPosition;
    private AudioSource customerAudio;

    void Start()
    {
        startPosition = transform.position;
        targetPosition = startPosition + targetOffset;
        customerAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        float t = Mathf.PingPong(Time.time * speed, 1f);
        transform.position = Vector3.Lerp(startPosition, targetPosition, t);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (customerAudio != null)
            {
                customerAudio.Play();
            }

            GameManager manager = FindObjectOfType<GameManager>();
            if (manager != null)
            {
                manager.LosePatience(patienceDamage);
            }
        }
    }
}