using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNav : MonoBehaviour
{

    public EnemyScript parentObject;
    public NavMeshAgent navAgent;
    public bool isRanged;
    public GameObject enemyProjectile;
    public float enemyAttackSpeed = 0.5f;
    float attackSpeedDelta;
    public Transform enemyAttackPoint;

    bool attackingPlayer;

    void Start()
    {
        
    }


    void Update()
    {



        if (isRanged)
        {
            if (attackingPlayer)
            {
                attackSpeedDelta += Time.deltaTime;
                if (attackSpeedDelta >= enemyAttackSpeed)
                {
                    Instantiate(enemyProjectile, enemyAttackPoint.transform.position, enemyAttackPoint.transform.rotation);
                    attackSpeedDelta = 0f;
                }
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (isRanged)
        {
            enemyAttackPoint.transform.LookAt(other.transform);
        }

        if (other.tag == "Player")
        {
            if (parentObject.enemyState == 0 || parentObject.enemyState == 1)
            {
                parentObject.enemyState = 1;
                navAgent.SetDestination(other.transform.position);
            }
            if (parentObject.enemyState == 3)
            {
                navAgent.SetDestination(transform.position);
            }
            if (isRanged)
            {
                attackingPlayer = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        parentObject.enemyState = 0;
        navAgent.SetDestination(transform.position);
        if (isRanged)
        {
            attackingPlayer = false;
        }
    }
}
