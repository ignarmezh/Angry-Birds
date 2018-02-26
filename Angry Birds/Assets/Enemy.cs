using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public GameObject deathEffect;

    public float health = 10f;

    public static int enemiesAlive = 0;

    private void Start()
    {
        enemiesAlive++;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.magnitude > health)
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(deathEffect,transform.position,Quaternion.identity);
        enemiesAlive--;
        if (enemiesAlive <= 0)
            Debug.Log("All dead");
        Destroy(gameObject);
    }
}
