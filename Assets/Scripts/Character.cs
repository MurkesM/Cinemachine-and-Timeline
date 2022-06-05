using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Character : MonoBehaviour
{
    [SerializeField] private CharacterController _controller;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotateSpeed;
    [SerializeField] GameObject[] _cubes;
    [SerializeField] CinemachineVirtualCamera _camera3rd;
    [SerializeField] CinemachineVirtualCamera _cameraH;
    [SerializeField] CinemachineVirtualCamera _cameraT;
    [SerializeField] CinemachineVirtualCamera _cameraLA;
    private Vector3 _direction;

    void Update()
    {
        float _horizontal = Input.GetAxis("Horizontal");
        float _vertical = Input.GetAxis("Vertical");
        _direction = new Vector3(0, 0, _vertical);
        _direction *= _moveSpeed * Time.deltaTime;
        _controller.Move(_direction);

        Vector3 rotation = new Vector3(0, _horizontal * _rotateSpeed * Time.deltaTime, 0);
        this.transform.Rotate(rotation);

        //if (Input.GetButton("Fire2"))
        //{
        //    _camera.enabled = false;
        //}
        //else
        //{
        //    _camera.enabled = true;
        //}
    }

    void OnTriggerEnter(Collider other)
    {
        foreach (GameObject cube in _cubes)
        {
            switch (other.tag)
            {
                case "VSH":
                    _cameraH.Priority = 11;
                    _camera3rd.Priority = 10;
                    break;
                case "VST":
                    _cameraT.Priority = 11;
                    _cameraH.Priority = 10;
                    break;
                case "VSLA":
                    _cameraLA.Priority = 11;
                    _cameraT.Priority = 10;
                    break;
                case "VS3":
                    _cameraLA.Priority = 10;
                    _camera3rd.Priority = 11;
                    break;
                default:
                    Debug.Log("No thing");
                    break;
            }
        }
    }
}