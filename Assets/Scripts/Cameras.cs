using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameras : MonoBehaviour
{
    [SerializeField] GameObject[] _cameras;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            _cameras[0].SetActive(false);
            _cameras[1].SetActive(false);
        }
    }
}