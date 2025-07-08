using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOrbit : MonoBehaviour
{
    public Transform target;               
    public Vector3 offset = new Vector3(0, 2, -5); 
    public float sensitivity = 10f;

    public float minY = -30f;               
    public float maxY = 60f;                

    private float rotX = 0f;                
    private float rotY = 0f;               

    void LateUpdate()
    {
        
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

       
        rotY += mouseX;
        rotX -= mouseY;
        rotX = Mathf.Clamp(rotX, minY, maxY);

        Quaternion rotation = Quaternion.Euler(rotX, rotY, 0);

        transform.position = target.position + rotation * offset;

        transform.LookAt(target);
    }
}
