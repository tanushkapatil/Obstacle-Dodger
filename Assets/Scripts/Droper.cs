using UnityEngine;

public class Droper : MonoBehaviour
{
    [SerializeField] float timeToWait ;
    void Start()
    {
        
    }

    void Update()
    {
        if(Time.time > timeToWait) {
            Debug.Log("Lookout!");
        }
    }
}
