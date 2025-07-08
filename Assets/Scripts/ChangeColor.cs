using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour, IShootable
{
    private Renderer _renderer;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        _renderer = GetComponent<Renderer>();
    }

    void IShootable.OnShot(Vector3 hitPoint) 
    {
        rb.position = hitPoint;
        Color randomColor = new Color( Random.value, Random.value, Random.value );
        _renderer.material.color = randomColor;

    }
    
}
