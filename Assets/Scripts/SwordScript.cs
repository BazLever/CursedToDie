using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordScript : MonoBehaviour
{

    public GameObject weaponDisplay;
    public GameObject attackProjectile;

    [Header("Weapon Stats")]
    public int damage = 50;
    public float attackSpeed = 0.25f;
    float attackSpeedDelta;
    public bool fullAuto = false;

    bool isActive = false;
    bool canAttack;



    void Start()
    {
        DeactivateWeapon();
    }

    void Update()
    {
        if (!canAttack)
        {
            attackSpeedDelta += Time.deltaTime;
            if (attackSpeedDelta >= attackSpeed)
            {
                canAttack = true;
                attackSpeedDelta = 0f;
            }
        }
    }

    public void OnFire(Transform attackPoint)
    {
        if (isActive)
        {
            if (canAttack)
            {
                Instantiate(attackProjectile, attackPoint.transform.position, attackPoint.transform.rotation);
                canAttack = false;
            }
        }
    }

    public void ActivateWeapon()
    {
        isActive = true;
        weaponDisplay.SetActive(true);
    }

    public void DeactivateWeapon()
    {
        isActive = false;
        weaponDisplay.SetActive(false);
    }


}
