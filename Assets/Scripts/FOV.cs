using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class FOV : MonoBehaviour
{
    CinemachineVirtualCamera _camera;
   [SerializeField] Transform _target1;
   [SerializeField] Transform _target2;

    void Start()
    {
        _camera = GetComponent<CinemachineVirtualCamera>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _camera.m_Lens.FieldOfView != 20)
        {
            _camera.m_Lens.FieldOfView -= 20;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && _camera.m_Lens.FieldOfView == 20)
            _camera.m_Lens.FieldOfView = 60;

        if (Input.GetKeyDown(KeyCode.E) && _camera.LookAt == _target1)
        {
            _camera.LookAt = _target2;
        }
        else if (Input.GetKeyDown(KeyCode.E) && _camera.LookAt == _target2)
        {
            _camera.LookAt = _target1;
        }
    }
}