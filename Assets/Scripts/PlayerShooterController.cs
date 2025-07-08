using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooterController : MonoBehaviour
{
    public Transform firePoint;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit, 100f))
            {
                IShootable shootable = hit.collider.GetComponent<IShootable>();
                if (shootable != null)
                {
                    shootable.OnShot(hit.point);
                }
            }
        }
    } 

}
