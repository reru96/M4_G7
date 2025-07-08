using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_1 : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float speed;
    [SerializeField] private float rotationSpeed;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * (rotationSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * mouseX);
    }
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        

        Vector3 dir = new Vector3(h, 0, v).normalized;
        Vector3 worldDir = transform.TransformDirection(dir);
        rb.MovePosition(rb.position + worldDir * (speed * Time.deltaTime));
    }

}
