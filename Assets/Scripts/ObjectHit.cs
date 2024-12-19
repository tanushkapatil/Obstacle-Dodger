using UnityEngine;

public class Object : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        Debug.Log("That's a Hit!") ;
   }
}
