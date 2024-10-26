using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationArm : MonoBehaviour
{
    float targetRotation = -135.0f;
    float startRotation = 0.0f;
    public float velocity = 0.01f;
    float currentRotation = 0;
    float rotationSpeed = 45.0f;

    void start(){
        
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.G)){
            Debug.Log( "Current angle: " + currentRotation);
            if((int)currentRotation >= targetRotation){
                currentRotation -= velocity*Time.deltaTime;
                transform.eulerAngles = new Vector3(0, 0, currentRotation) * Time.deltaTime * rotationSpeed;
            }
        }

        if(Input.GetKey(KeyCode.H)){
            Debug.Log( "Current angle: " + currentRotation);
            if((int)currentRotation <= startRotation){
                currentRotation += velocity*Time.deltaTime;
                transform.eulerAngles = new Vector3(0, 0, currentRotation) * Time.deltaTime * rotationSpeed;
            }
            
        }
        
    }
}
