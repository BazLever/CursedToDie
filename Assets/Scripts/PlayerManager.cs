using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public bool killPlayer = false;
    [Header("PlayerStats")]
    public int playerHealth;

    [Header("Other")]
    public GameObject mainCamera;
    public GameObject playerDeadBody;

    PlayerMovement playerMovement;


    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    void Update()
    {
        


        if (killPlayer)
        {
            PlayerDeath();
        }
    }

    public void PlayerDeath()
    {
        playerMovement.OnDeath();
        playerDeadBody.SetActive(true);
        mainCamera.SetActive(false);
    }
}
