using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{

    public Transform attackPoint;
    [Header("Weapons")]
    public SwordScript[] weapons;
    public bool[] ownedWeapon;
    public int weaponActive;
        
    void Start()
    {
        
    }

    void Update()
    {

        //Weapon Switching
        // ================================================
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            weapons[0].ActivateWeapon();
            weapons[1].DeactivateWeapon();
            weapons[2].DeactivateWeapon();
            weapons[3].DeactivateWeapon();
            weaponActive = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && ownedWeapon[0])
        {
            weapons[1].ActivateWeapon();
            weapons[0].DeactivateWeapon();
            weapons[2].DeactivateWeapon();
            weapons[3].DeactivateWeapon();
            weaponActive = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && ownedWeapon[1])
        {
            weapons[2].ActivateWeapon();
            weapons[0].DeactivateWeapon();
            weapons[1].DeactivateWeapon();
            weapons[3].DeactivateWeapon();
            weaponActive = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) && ownedWeapon[2])
        {
            weapons[3].ActivateWeapon();
            weapons[0].DeactivateWeapon();
            weapons[1].DeactivateWeapon();
            weapons[2].DeactivateWeapon();
            weaponActive = 3;
        }
        // ================================================


        //Weapon Function
        // ================================================
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            weapons[weaponActive].OnFire(attackPoint);
        }
        // ================================================


    }
}
