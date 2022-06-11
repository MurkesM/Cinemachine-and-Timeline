using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    [SerializeField] CameraManager _cameraManager;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _cameraManager.canSwitchCams = true;
            _cameraManager.SetLowCamPriorities();
            _cameraManager.currentCamera = 1;
            _cameraManager.SetCurrentCamera();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            _cameraManager.canSwitchCams = false;
            _cameraManager.SetLowCamPriorities();
            _cameraManager.currentCamera = 0;
            _cameraManager.SetCurrentCamera();
        }
    }
}