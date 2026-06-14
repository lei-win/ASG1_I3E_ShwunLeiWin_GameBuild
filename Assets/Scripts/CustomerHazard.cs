using UnityEngine;

public class CustomerHazard : MonoBehaviour
{
    public Vector3 targetOffset;
    public float speed = 2f;
    public int patienceDamage = 1;

    private Vector3 startPosition;
    private Vector3 targetPosition;
    private AudioSource customerAudio;
    private bool movingToTarget = true;

    void Start()
    {
        startPosition = transform.position;
        targetPosition = startPosition + targetOffset;
        customerAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        float t = Mathf.PingPong(Time.time * speed, 1f);
        
        if (movingToTarget && t >= 0.99f)
        {
            movingToTarget = false;
        }
        else if (!movingToTarget && t <= 0.01f)
        {
            movingToTarget = true;
        }

        Vector3 nextPosition = Vector3.Lerp(startPosition, targetPosition, t);
        
        Vector3 moveDirection = nextPosition - transform.position;
        if (moveDirection != Vector3.zero)
        {
            transform.forward = moveDirection.normalized;
        }

        transform.position = nextPosition;
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