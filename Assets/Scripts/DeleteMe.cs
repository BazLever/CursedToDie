using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteMe : MonoBehaviour
{

    public float timeTilDeath;
    float deathDelta;
    public int damage;
    public bool isBullet;
    Rigidbody rb;
    public float rbSpeed;
    public float bulletVariance;

    private void Start()
    {
        if (isBullet)
        {
            transform.Rotate((Random.Range(-bulletVariance, bulletVariance)), (Random.Range(-bulletVariance, bulletVariance)), 0);
            rb = GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * rbSpeed);
        }
    }

    void Update()
    {

        deathDelta += Time.deltaTime;
        if (deathDelta >= timeTilDeath)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Debug.Log("Hit enemy!");
            other.GetComponent<EnemyScript>().Damaged(damage);
        }
        Destroy(gameObject);
    }
}
