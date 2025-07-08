using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : MonoBehaviour, IShootable
{
    private Rigidbody rb;
    public Transform[] positions;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void IShootable.OnShot(Vector3 hitPoint)
    {
        hitPoint = rb.position;
        Transform randomPosition = positions[Random.Range(0, positions.Length)];
        rb.MovePosition(randomPosition.position);
    }
}
