using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimandDeath : MonoBehaviour
{
    
   [SerializeField] Animator _animator;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
            _animator.SetBool("isRunning", true);
        else
            _animator.SetBool("isRunning", false);
    }
}
