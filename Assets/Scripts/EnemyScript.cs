using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{

    public int health;


    public int enemyState = 0;
    //Enemy States:
    // 0 - Idle
    // 1 - Walking
    // 2 - Attacking
    // 3 - Stagger
    // 4 - Dead

    float staggerDelta;

    void Start()
    {
        
    }

    void Update()
    {
        if (enemyState == 3)
        {
            staggerDelta += Time.deltaTime;
            if (staggerDelta >= 0.25f)
            {
                enemyState = 0;
                staggerDelta = 0f;
            }
        }
    }

    public void Damaged(int damage)
    {
        health -= damage;
        enemyState = 3;

        if (health <= 0)
        {
            EnemyDeath();
        }
    }

    public void EnemyDeath()
    {
        enemyState = 4;
        Destroy(gameObject);
    }
}
