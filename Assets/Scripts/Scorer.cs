using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hit = 0 ;
    private void OnCollisionEnter(Collision other) {
        hit++ ;
        Debug.Log("You've bumped into the object " + hit + " times.");
    }
}
