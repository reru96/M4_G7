using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IShootable
{

    public int maxHp = 10;
    private int currentHp; 
    private Rigidbody _rb;

   
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        currentHp = maxHp;
    } 

    public void TakeDamage(int amount)
    {
        currentHp -= amount;
        currentHp = Mathf.Clamp(currentHp,0, maxHp);
        if(currentHp < 0)
        {
            Destroy (gameObject);
        }

    }
 
    void IShootable.OnShot(Vector3 hitPoint)
    {
        hitPoint = _rb.position;
        TakeDamage(1);
        Debug.Log("Hp: " + currentHp);
    }
}
