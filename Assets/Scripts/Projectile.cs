using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] Transform player ;
    [SerializeField] float speed = 1.0f ;
    Vector3 playerPosition ;
    void Start()
    {
        playerPosition = player.transform.position ;
    }

    // Update is called once per frame
    void Update()
    {
        MoveToPlayer() ;
        DestroyWhenReached() ;
    }

    void MoveToPlayer() {
        transform.position = Vector3.MoveTowards(transform.position,playerPosition, Time.deltaTime*speed) ;
    }

    void DestroyWhenReached() {
        if(transform.position == player.position) {
            Destroy(gameObject) ;
        }
    }
}
