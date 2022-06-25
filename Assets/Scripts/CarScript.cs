using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;


public class CarScript : MonoBehaviour
{
    [SerializeField] PlayableDirector _director;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            _director.Play();
    }
}