using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Camera FPCamera;
    [SerializeField] private float range = 100f;
    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        RaycastHit hit;
        bool intersection = Physics.Raycast(FPCamera.transform.position, FPCamera.transform.forward, out hit, range);
        if (intersection)
        {
            Debug.Log("You hit " + hit.transform.name);
        }
    }
}
