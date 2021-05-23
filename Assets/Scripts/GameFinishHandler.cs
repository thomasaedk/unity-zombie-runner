using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFinishHandler : MonoBehaviour
{
    [SerializeField] private Canvas gameFinishedCanvas;

    private void Start()
    {
        gameFinishedCanvas.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        gameFinishedCanvas.enabled = true;   
        Time.timeScale = 0;
        FindObjectOfType<WeaponSwitcher>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
