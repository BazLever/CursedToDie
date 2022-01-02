using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    public int health;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Damaged(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            EnemyDeath();
        }
    }

    public void EnemyDeath()
    {
        Destroy(gameObject);
    }
}
