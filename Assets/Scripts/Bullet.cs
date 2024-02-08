using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 50;
    public Rigidbody2D rb;
    public GameObject impactEffect;
    //Bullet rigidbody and speed
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right*speed;
    }
    void OnTriggerEnter2D (Collider2D hitInfo){
        Debug.Log(hitInfo.name);
        PlayerMovement player = hitInfo.GetComponent<PlayerMovement>();
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        EnemyGFX flyer = hitInfo.GetComponent<EnemyGFX>();
        if (player == null){
            Instantiate(impactEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        if (enemy != null){
            enemy.TakeDamage(damage);
        }
        if (flyer != null){
            flyer.FlyerDamage(damage);
        }
    }
}
