using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] GameObject[] _cameras;
    public int currentCamera;
    public bool canSwitchCams;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C) && canSwitchCams == true)
        {
            currentCamera++;

            if (currentCamera >= _cameras.Length)
            {
                currentCamera = 1;
            }
        }
        SetLowCamPriorities();
        SetCurrentCamera();
    }

    public void SetLowCamPriorities()
    {
        foreach (GameObject camera in _cameras)
        {
            if (camera.GetComponent<CinemachineVirtualCamera>())
            {
                camera.GetComponent<CinemachineVirtualCamera>().Priority = 10;
            }
            if (camera.GetComponent<CinemachineBlendListCamera>())
            {
                camera.GetComponent<CinemachineBlendListCamera>().Priority = 10;
            }
        }
    }

    public void SetCurrentCamera()
    {
        if (_cameras[currentCamera].GetComponent<CinemachineVirtualCamera>())
        {
            _cameras[currentCamera].GetComponent<CinemachineVirtualCamera>().Priority = 15;
        }
        if (_cameras[currentCamera].GetComponent<CinemachineBlendListCamera>())
        {
            _cameras[currentCamera].GetComponent<CinemachineBlendListCamera>().Priority = 15;
        }
    }
}
