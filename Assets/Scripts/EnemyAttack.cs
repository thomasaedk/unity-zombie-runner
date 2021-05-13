using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    private PlayerHealth target;
    [SerializeField] private float damage = 40f;
        
    void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
    }

    public void AttackHitEvent()
    {
        if (target == null)
        {
            return;
        }
        Debug.Log("Bang bang");
        target.TakeDamage(damage);
    }
}
