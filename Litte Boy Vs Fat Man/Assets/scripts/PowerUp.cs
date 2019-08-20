using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : ScriptableObject
{
    private string powerUpType;
    public string PowerUpType { get => powerUpType; set => powerUpType = value; }

    private GameObject powerUpPrefab;
    public GameObject PowerupPrefab { get => powerUpPrefab; set => powerUpPrefab = value; }
    public GameObject fasterBulletPowerUp;

    private void OnEnable()
    {
        if (PowerUpType == "faster-bullet")
        {

            //PowerupPrefab
        }
        else
        {
            //PowerupPrefab = 
        }
    }
}
