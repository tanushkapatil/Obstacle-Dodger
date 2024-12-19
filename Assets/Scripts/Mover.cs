using Unity.Collections;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]float moveSpeed = 10f;
    void Start() {
        PrintInstructions() ;
    }

    void Update() {
        MovePlayer() ;
    }

    void PrintInstructions() {
        Debug.Log("Welcome to the Game!");
    }

    void MovePlayer() {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed ; 
        float yValue = 0f ;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed ;
        transform.Translate(xValue, yValue, zValue) ;
    }
}