using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraTest : MonoBehaviour
{
   [SerializeField] CinemachineVirtualCamera _camStatic;
   [SerializeField] CinemachineVirtualCamera _camManual;
   [SerializeField] CinemachineVirtualCamera _camSecurity;
   [SerializeField] CinemachineVirtualCamera[] _cameras;

    void Start()
    {
        
    }

    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.C))
        //{
        //    foreach (CinemachineVirtualCamera camera in _cameras)
        //    {
        //        if 
        //    }
        //}
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _camStatic.enabled = true;
            _camManual.enabled = true;
            _camSecurity.enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _camStatic.enabled = false;
            _camManual.enabled = false;
            _camSecurity.enabled = false;
        }
    }
}