using UnityEngine;

public class Droper : MonoBehaviour
{
    [SerializeField] float timeToWait ;
    MeshRenderer myMeshRenderer ;
    Rigidbody myRigidBody ;
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>() ;
        myRigidBody = GetComponent<Rigidbody>() ;
        myMeshRenderer.enabled = false ;
        myRigidBody.useGravity = false ;
    }

    void Update()
    {
        if(Time.time > timeToWait) {
            myMeshRenderer.enabled = true ;
            myRigidBody.useGravity = true ;
        }
    }
}
