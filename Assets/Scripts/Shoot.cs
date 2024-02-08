using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.B)){
            Fire();
        }
    }
    private void Fire(){
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
