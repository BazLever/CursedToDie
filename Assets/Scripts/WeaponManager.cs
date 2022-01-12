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
    bool fullAuto;
        
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
            fullAuto = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && ownedWeapon[0])
        {
            weapons[1].ActivateWeapon();
            weapons[0].DeactivateWeapon();
            weapons[2].DeactivateWeapon();
            weapons[3].DeactivateWeapon();
            weaponActive = 1;
            fullAuto = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && ownedWeapon[1])
        {
            weapons[2].ActivateWeapon();
            weapons[0].DeactivateWeapon();
            weapons[1].DeactivateWeapon();
            weapons[3].DeactivateWeapon();
            weaponActive = 2;
            fullAuto = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) && ownedWeapon[2])
        {
            weapons[3].ActivateWeapon();
            weapons[0].DeactivateWeapon();
            weapons[1].DeactivateWeapon();
            weapons[2].DeactivateWeapon();
            weaponActive = 3;
            fullAuto = false;
        }
        // ================================================


        //Weapon Function
        // ================================================
        if (Input.GetKeyDown(KeyCode.Mouse0) && !fullAuto)
        {
            weapons[weaponActive].OnFire(attackPoint);
        }

        if (Input.GetKey(KeyCode.Mouse0) && fullAuto)
        {
            weapons[weaponActive].OnFire(attackPoint);
        }
        // ================================================


    }
}
