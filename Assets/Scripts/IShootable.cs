using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShootable
{
    public void OnShot(Vector3 hitPoint);
}