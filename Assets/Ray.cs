using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ray : MonoBehaviour
{
    public GameObject impactEffect;
    public Transform firePoint;
    private float nextShot = 0.15f;
    private float fireDelay = 2f;
    public int damage = 10;
    public LineRenderer lineRenderer;
    private void Update() {
        StartCoroutine(Laser());
    }
    IEnumerator Laser(){
        RaycastHit2D hitInfo = Physics2D.Raycast(firePoint.position, firePoint.right);
        if (hitInfo){
            PlayerMovement player = hitInfo.transform.GetComponent<PlayerMovement>();
            if (player != null && Time.time > nextShot){
                lineRenderer.enabled = true;
                Instantiate(impactEffect, hitInfo.point, Quaternion.identity);
                player.PlayerDamage(damage);
                lineRenderer.SetPosition(0, firePoint.position);
                lineRenderer.SetPosition(1, hitInfo.point);
                nextShot = fireDelay + Time.time;
                lineRenderer.enabled = true;
                yield return new WaitForSeconds(0.1f);
                lineRenderer.enabled = false;
            }
        }
    }

}
