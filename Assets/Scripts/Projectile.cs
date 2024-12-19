using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float speed = 1.0f;
    Vector3 playerPosition;

    void Awake() {
        gameObject.SetActive(false);        
    }

    void Start()
    {
        playerPosition = player.transform.position; 
    }
    
    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }

    void MoveToPlayer() {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * speed);
    }

    void DestroyWhenReached() {
        if (Vector3.Distance(transform.position, playerPosition) < 0.01f) {
            Destroy(gameObject);
        }
    }
}
