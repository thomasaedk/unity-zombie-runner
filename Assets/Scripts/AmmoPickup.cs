using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    [SerializeField] private int ammoAmount = 5;
    [SerializeField] private AmmoType _ammoType;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            FindObjectOfType<Ammo>().IncreaseCurrentAmmo(_ammoType, ammoAmount);
            Destroy(gameObject);
        }
    }
}
