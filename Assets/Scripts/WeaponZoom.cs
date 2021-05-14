using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] private Camera _fpsCamera;
    [SerializeField] private RigidbodyFirstPersonController fpsController;
    [SerializeField] private float zoomedOutFov = 60f;
    [SerializeField] private float zoomedInFov = 20f;

    [SerializeField] private float zoomedOutMouseSensitvity = 2f;
    [SerializeField] private float zoomedInMouseSensitvity = .5f;

    private bool zoomedInToggle = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (!zoomedInToggle)
            {
                zoomedInToggle = true;
                _fpsCamera.fieldOfView = zoomedInFov;
                fpsController.mouseLook.XSensitivity = zoomedInMouseSensitvity;
                fpsController.mouseLook.YSensitivity = zoomedInMouseSensitvity;
            }
            else
            {
                zoomedInToggle = false;
                _fpsCamera.fieldOfView = zoomedOutFov;
                fpsController.mouseLook.XSensitivity = zoomedOutMouseSensitvity;
                fpsController.mouseLook.YSensitivity = zoomedOutMouseSensitvity;
            }
        }
    }
}
