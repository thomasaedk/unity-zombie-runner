using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] private Camera _fpsCamera;
    [SerializeField] private float zoomedOutFov = 60f;
    [SerializeField] private float zoomedInFov = 20f;

    [SerializeField] private float zoomedOutMouseSensitvity = 2f;
    [SerializeField] private float zoomedInMouseSensitvity = .5f;

    private MouseLook _mouseLook;
    private bool zoomedInToggle = false;

    private void Start()
    {
        _mouseLook = GetComponent<RigidbodyFirstPersonController>().mouseLook;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (!zoomedInToggle)
            {
                zoomedInToggle = true;
                _fpsCamera.fieldOfView = zoomedInFov;
                _mouseLook.XSensitivity = zoomedInMouseSensitvity;
                _mouseLook.YSensitivity = zoomedInMouseSensitvity;
            }
            else
            {
                zoomedInToggle = false;
                _fpsCamera.fieldOfView = zoomedOutFov;
                _mouseLook.XSensitivity = zoomedOutMouseSensitvity;
                _mouseLook.YSensitivity = zoomedOutMouseSensitvity;
            }
        }
    }
}
