using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 200;
    public GameObject deathEffect;
    public void TakeDamage (int damage) {
        health -= damage;
        if (health <= 0){
            Die();
        }
    }
    public void Die() {
        Instantiate(deathEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
