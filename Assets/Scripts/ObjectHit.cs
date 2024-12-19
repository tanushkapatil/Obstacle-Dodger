using UnityEngine;

public class Object : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        GetComponent<MeshRenderer>().material.color = Color.black ;
        Debug.Log("That's a Hit!") ;
   }
}
