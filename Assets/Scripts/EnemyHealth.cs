using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private float hitPoints = 100f;
    private bool isDead = false;
    public bool IsDead => isDead;

    public void TakeDamage(float damage)
    {
        if (isDead)
        {
            return;
        }
        BroadcastMessage("OnDamageTaken");
        hitPoints -= damage;
        if (hitPoints <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        GetComponent<Animator>().SetTrigger("die");
        isDead = true;
    }
}
