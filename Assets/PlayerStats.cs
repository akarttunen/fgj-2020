﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "Collectable")
        {
            gameManager.collectedItems++;
        }
    }
}
